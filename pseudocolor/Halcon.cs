using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using HalconDotNet;

namespace pseudocolor
{
    class Halcon
    {
        
        public List<string> searchChar = new List<string>();
        public List<double> searchPosX = new List<double>();
        public List<double> searchPosY = new List<double>();

        public static void Bitmap2HObjectBpp32(Bitmap bmp, out HObject image)
        {
            try
            {
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

                //PixelFormat.Format24bppRgb
                BitmapData srcBmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);
                HOperatorSet.GenImageInterleaved(out image, srcBmpData.Scan0, "bgrx", bmp.Width, bmp.Height, 0, "byte", 0, 0, 0, 0, -1, 0);
                bmp.UnlockBits(srcBmpData);

            }
            catch (Exception ex)
            {
                image = null;
            }
        }

        public void GetSearchFileInfo(Bitmap image, out List<string> charResult, out List<double> searchPosXResult, out List<double> searchPosYResult)
        {
            // Local iconic variables
            HObject ho_Image, ho_Region1 = null, ho_ConnectedRegions = null;
            HObject ho_SelectedRegions1 = null, ho_RegionUnion = null, ho_RegionClosing = null;
            HObject ho_ConnectedRegions1 = null, ho_RegionTrans = null;
            HObject ho_RegionDilation = null, ho_SortedRegions = null, ho_ObjectSelected = null;
            HObject ho_RegionIntersection = null, ho_SortedRegions1 = null;
            HObject ho_ObjectSelected1 = null, ho_ObjectsDiff = null;

            // Local control variables 
            HTuple hv_ImageFiles = new HTuple(), hv_Width = new HTuple();
            HTuple hv_Height = new HTuple(), hv_WindowHandle = new HTuple();
            HTuple hv_OCRHandle = new HTuple(), hv_WidthCharacter = new HTuple();
            HTuple hv_HeightCharacter = new HTuple(), hv_Interpolation = new HTuple();
            HTuple hv_Features = new HTuple(), hv_Characters = new HTuple();
            HTuple hv_NumHidden = new HTuple(), hv_Preprocessing = new HTuple();
            HTuple hv_NumComponents = new HTuple(), hv_OCRHandle1 = new HTuple();
            HTuple hv_Index1 = new HTuple(), hv_UsedThreshold1 = new HTuple();
            HTuple hv_Number = new HTuple(), hv_Index2 = new HTuple();
            HTuple hv_Number1 = new HTuple(), hv_Class = new HTuple();
            HTuple hv_Confidence = new HTuple(), hv_Indices = new HTuple();
            HTuple hv_Class1 = new HTuple(), hv_Confidence1 = new HTuple();
            HTuple hv_Extended = new HTuple(), hv_Sum = new HTuple();
            HTuple hv_Class2 = new HTuple(), hv_Confidence2 = new HTuple();
            HTuple hv_Area = new HTuple(), hv_Row = new HTuple(), hv_Column = new HTuple();
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Image);
            HOperatorSet.GenEmptyObj(out ho_Region1);
            HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegions1);
            HOperatorSet.GenEmptyObj(out ho_RegionUnion);
            HOperatorSet.GenEmptyObj(out ho_RegionClosing);
            HOperatorSet.GenEmptyObj(out ho_ConnectedRegions1);
            HOperatorSet.GenEmptyObj(out ho_RegionTrans);
            HOperatorSet.GenEmptyObj(out ho_RegionDilation);
            HOperatorSet.GenEmptyObj(out ho_SortedRegions);
            HOperatorSet.GenEmptyObj(out ho_ObjectSelected);
            HOperatorSet.GenEmptyObj(out ho_RegionIntersection);
            HOperatorSet.GenEmptyObj(out ho_SortedRegions1);
            HOperatorSet.GenEmptyObj(out ho_ObjectSelected1);
            HOperatorSet.GenEmptyObj(out ho_ObjectsDiff);

            ho_Image.Dispose();            

            Bitmap2HObjectBpp32(image, out ho_Image); // 여기서 비트맵 이미지를 ho_Image로 컨버팅한다.

            hv_Width.Dispose(); hv_Height.Dispose();
            HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);

            //문자가 3개일때 첫번째 문자는 영문으로 인식하기 위해
            hv_OCRHandle.Dispose();
            HOperatorSet.ReadOcrClassMlp("Document_A-Z+_NoRej.omc", out hv_OCRHandle);
            hv_WidthCharacter.Dispose(); hv_HeightCharacter.Dispose(); hv_Interpolation.Dispose(); hv_Features.Dispose(); hv_Characters.Dispose(); hv_NumHidden.Dispose(); hv_Preprocessing.Dispose(); hv_NumComponents.Dispose();
            HOperatorSet.GetParamsOcrClassMlp(hv_OCRHandle, out hv_WidthCharacter, out hv_HeightCharacter,
                out hv_Interpolation, out hv_Features, out hv_Characters, out hv_NumHidden,
                out hv_Preprocessing, out hv_NumComponents);
            //나머지는 숫자로 인식
            hv_OCRHandle1.Dispose();
            HOperatorSet.ReadOcrClassMlp("Document_0-9_NoRej.omc", out hv_OCRHandle1);

            //using (HDevDisposeHelper dh = new HDevDisposeHelper())
            //{
            //    ho_Image.Dispose();
            //    HOperatorSet.ReadImage(out ho_Image, hv_ImageFiles.TupleSelect(hv_Index1));
            //}
            //if (HDevWindowStack.IsOpen())
            //{
            //    HOperatorSet.DispObj(ho_Image, HDevWindowStack.GetActive());
            //}

            //검사영역제한
            ho_Region1.Dispose(); hv_UsedThreshold1.Dispose();
            HOperatorSet.BinaryThreshold(ho_Image, out ho_Region1, "max_separability",
                "dark", out hv_UsedThreshold1);
            ho_ConnectedRegions.Dispose();
            HOperatorSet.Connection(ho_Region1, out ho_ConnectedRegions);
            ho_SelectedRegions1.Dispose();
            HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions1, "area",
                "and", 10, 100);
            ho_RegionUnion.Dispose();
            HOperatorSet.Union1(ho_SelectedRegions1, out ho_RegionUnion);
            ho_RegionClosing.Dispose();
            HOperatorSet.ClosingCircle(ho_RegionUnion, out ho_RegionClosing, 10.5);
            ho_ConnectedRegions1.Dispose();
            HOperatorSet.Connection(ho_RegionClosing, out ho_ConnectedRegions1);
            ho_RegionTrans.Dispose();
            HOperatorSet.ShapeTrans(ho_ConnectedRegions1, out ho_RegionTrans, "rectangle1");
            ho_RegionDilation.Dispose();
            HOperatorSet.DilationCircle(ho_RegionTrans, out ho_RegionDilation, 10.5);

            //sort
            ho_SortedRegions.Dispose();
            HOperatorSet.SortRegion(ho_RegionDilation, out ho_SortedRegions, "character",
                "true", "row");
            hv_Number.Dispose();
            HOperatorSet.CountObj(ho_SortedRegions, out hv_Number);

            HTuple end_val32 = hv_Number;
            HTuple step_val32 = 1;
            for (hv_Index2 = 1; hv_Index2.Continue(end_val32, step_val32); hv_Index2 = hv_Index2.TupleAdd(step_val32))
            {
                //검사 문자 선택
                ho_ObjectSelected.Dispose();
                HOperatorSet.SelectObj(ho_SortedRegions, out ho_ObjectSelected, hv_Index2);
                ho_RegionIntersection.Dispose();
                HOperatorSet.Intersection(ho_SelectedRegions1, ho_ObjectSelected, out ho_RegionIntersection
                    );
                ho_SortedRegions1.Dispose();
                HOperatorSet.SortRegion(ho_RegionIntersection, out ho_SortedRegions1, "character",
                    "true", "row");
                hv_Number1.Dispose();
                HOperatorSet.CountObj(ho_SortedRegions1, out hv_Number1);

                //첫번째 문자 검사 시 영문인지 체크
                ho_ObjectSelected1.Dispose();
                HOperatorSet.SelectObj(ho_SortedRegions1, out ho_ObjectSelected1, 1);
                hv_Class.Dispose(); hv_Confidence.Dispose();
                HOperatorSet.DoOcrSingleClassMlp(ho_ObjectSelected1, ho_Image, hv_OCRHandle,
                    1, out hv_Class, out hv_Confidence);
                hv_Indices.Dispose();
                HOperatorSet.TupleFind(hv_Characters, hv_Class, out hv_Indices);
                if ((int)((new HTuple(hv_Indices.TupleNotEqual(0))).TupleAnd(new HTuple(hv_Confidence.TupleGreater(
                    0.8)))) != 0)
                {
                    //나머지 문자는 숫자로 인식
                    ho_ObjectsDiff.Dispose();
                    HOperatorSet.ObjDiff(ho_SortedRegions1, ho_ObjectSelected1, out ho_ObjectsDiff
                        );
                    hv_Class1.Dispose(); hv_Confidence1.Dispose();
                    HOperatorSet.DoOcrMultiClassMlp(ho_ObjectsDiff, ho_Image, hv_OCRHandle1,
                        out hv_Class1, out hv_Confidence1);
                    hv_Extended.Dispose();
                    HOperatorSet.TupleInsert(hv_Class, 1, hv_Class1, out hv_Extended);
                    hv_Sum.Dispose();
                    HOperatorSet.TupleSum(hv_Extended, out hv_Sum);
                }
                else
                {
                    //숫자로 인식
                    hv_Class2.Dispose(); hv_Confidence2.Dispose();
                    HOperatorSet.DoOcrMultiClassMlp(ho_SortedRegions1, ho_Image, hv_OCRHandle1,
                        out hv_Class2, out hv_Confidence2);
                    hv_Sum.Dispose();
                    HOperatorSet.TupleSum(hv_Class2, out hv_Sum);
                }
                //디스플레이
                hv_Area.Dispose(); hv_Row.Dispose(); hv_Column.Dispose();
                HOperatorSet.AreaCenter(ho_ObjectSelected, out hv_Area, out hv_Row, out hv_Column);

                searchChar.Add(hv_Sum);
                searchPosX.Add(hv_Row);
                searchPosY.Add(hv_Column);
                //if (HDevWindowStack.IsOpen())
                //{
                //    HOperatorSet.SetDraw(HDevWindowStack.GetActive(), "margin");
                //}
                //if (HDevWindowStack.IsOpen())
                //{
                //    HOperatorSet.DispObj(ho_ObjectSelected, HDevWindowStack.GetActive());
                //}
                //if (HDevWindowStack.IsOpen())
                //{
                //    HOperatorSet.SetDraw(HDevWindowStack.GetActive(), "fill");
                //}
                //if (HDevWindowStack.IsOpen())
                //{
                //    HOperatorSet.DispObj(ho_SortedRegions1, HDevWindowStack.GetActive());
                //}
                //if (HDevWindowStack.IsOpen())
                //{
                //    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                //    {
                //        HOperatorSet.DispText(HDevWindowStack.GetActive(), (((hv_Sum + "\nRow : ") + hv_Row) + "\nCol : ") + hv_Column,
                //            "image", hv_Row + 10, hv_Column, "black", new HTuple(), new HTuple());
                //    }
                //}                
            }

            ho_Image.Dispose();
            ho_Region1.Dispose();
            ho_ConnectedRegions.Dispose();
            ho_SelectedRegions1.Dispose();
            ho_RegionUnion.Dispose();
            ho_RegionClosing.Dispose();
            ho_ConnectedRegions1.Dispose();
            ho_RegionTrans.Dispose();
            ho_RegionDilation.Dispose();
            ho_SortedRegions.Dispose();
            ho_ObjectSelected.Dispose();
            ho_RegionIntersection.Dispose();
            ho_SortedRegions1.Dispose();
            ho_ObjectSelected1.Dispose();
            ho_ObjectsDiff.Dispose();

            hv_ImageFiles.Dispose();
            hv_Width.Dispose();
            hv_Height.Dispose();
            hv_WindowHandle.Dispose();
            hv_OCRHandle.Dispose();
            hv_WidthCharacter.Dispose();
            hv_HeightCharacter.Dispose();
            hv_Interpolation.Dispose();
            hv_Features.Dispose();
            hv_Characters.Dispose();
            hv_NumHidden.Dispose();
            hv_Preprocessing.Dispose();
            hv_NumComponents.Dispose();
            hv_OCRHandle1.Dispose();
            hv_Index1.Dispose();
            hv_UsedThreshold1.Dispose();
            hv_Number.Dispose();
            hv_Index2.Dispose();
            hv_Number1.Dispose();
            hv_Class.Dispose();
            hv_Confidence.Dispose();
            hv_Indices.Dispose();
            hv_Class1.Dispose();
            hv_Confidence1.Dispose();
            hv_Extended.Dispose();
            hv_Sum.Dispose();
            hv_Class2.Dispose();
            hv_Confidence2.Dispose();
            hv_Area.Dispose();
            hv_Row.Dispose();
            hv_Column.Dispose();

            charResult = searchChar;
            searchPosXResult = searchPosX;
            searchPosYResult = searchPosY;
        }

        public double blobDetection(Bitmap image)
        {
            HObject ho_Image, ho_BrightPixels, ho_Particles;

            // Local control variables 

            HTuple hv_WindowHandle = new HTuple(), hv_Area = new HTuple();
            HTuple hv_Row = new HTuple(), hv_Column = new HTuple();
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Image);
            HOperatorSet.GenEmptyObj(out ho_BrightPixels);
            HOperatorSet.GenEmptyObj(out ho_Particles);
            //dev_update_off();
            //if (HDevWindowStack.IsOpen())
            //{
            //    hv_WindowHandle = HDevWindowStack.GetActive();
            //}

            ho_Image.Dispose();
            Bitmap2HObjectBpp32(image, out ho_Image); // 여기서 비트맵 이미지를 ho_Image로 컨버팅한다.
            //HOperatorSet.ReadImage(out ho_Image, "E:/2D_Image/2021_11_18/2021_11_18_09_22_18.b22p.bmp");
            ho_BrightPixels.Dispose();
            HOperatorSet.Threshold(ho_Image, out ho_BrightPixels, 0, 128);
            ho_Particles.Dispose();
            HOperatorSet.Connection(ho_BrightPixels, out ho_Particles);
            hv_Area.Dispose(); hv_Row.Dispose(); hv_Column.Dispose();
            HOperatorSet.AreaCenter(ho_Particles, out hv_Area, out hv_Row, out hv_Column);

            double SumArea = 0;

            for (int n = 0; n < hv_Area.Length; n++)
            {
                if (hv_Area[n] > 500)
                {
                    SumArea += hv_Area[n];
                }
            }
            //for Index1 := 1 to |Row| by 1
            //using (HDevDisposeHelper dh = new HDevDisposeHelper())
            //{
            //    disp_message(hv_WindowHandle, (((((((((((("Area: " + hv_Area) + "\n") + "Row: ") + hv_Row) + "\n") + "Column: ") + hv_Column) + "\n") + "Pos X: ") + hv_Column) + "\n") + "Pos Y: ") + hv_Row,
            //        "image", hv_Row + 30, hv_Column + 30, "black", "true");
            //}
            //endfor
            
            ho_Image.Dispose();
            ho_BrightPixels.Dispose();
            ho_Particles.Dispose();

            hv_WindowHandle.Dispose();
            hv_Area.Dispose();
            hv_Row.Dispose();
            hv_Column.Dispose();

            return SumArea;
        }
    }
}
