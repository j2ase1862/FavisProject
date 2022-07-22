using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Blob;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;

using System.IO.Ports;
using System.IO;

using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ImageProcessing;
using Point = OpenCvSharp.Point;

using Aspose;
using Aspose.OCR;

using NeoAPI;

namespace pseudocolor
{
    public partial class Form1 : Form
    {
        private Mat srcImg;
        private Mat dstImg;

        List<string> strings = new List<string>();
        List<string> stringsContent = new List<string>();
        List<string> copystrings = new List<string>();

        Mat bin;
        Mat blobcontour;
        Mat roi;
        Mat Reverse;
        Mat circle;

        //public NeoAPI.Image neoImage = new NeoAPI.Image();
        OpenCvSharp.Point roiStartPoint;

        Mat Origin;
        Mat Canny;
        Mat CannyColor;
        Mat im_gray;
        Mat blurreDst;

        Mat dilate, erode;

        Mat GrayMaster;
        Mat Master;

        public CogRectangle cogROI = new CogRectangle();

        private System.Drawing.Point pStart;
        private System.Drawing.Point pEnd;

        string str_Path_bin;

        private Bitmap mBitmap;

        public List<string> searchChar = new List<string>();
        public List<double> searchPosX = new List<double>();
        public List<double> searchPosY = new List<double>();


        public Form1()
        {
            cogROI = new CogRectangle();

            cogROI.SetCenterWidthHeight(200, 200, 500, 500);            

            cogROI.GraphicDOFEnable = CogRectangleDOFConstants.All;
            cogROI.Interactive = true;

            InitializeComponent();
        }

        private unsafe void Camera_Display()
        {  
            cogDisplay2.Image = null;

            //Mat im_gray = new Mat();
            //////Mat im_gray = Cv2.ImRead("test.bmp", ImreadModes.Grayscale);

            //////pictureBoxIpl3.ImageIpl = im_gray;

            //////Mat im_color = new Mat();
            //////Cv2.ApplyColorMap(im_gray, im_color, ColormapTypes.Jet);

            //////frame = im_color;

            //////pictureBoxIpl2.ImageIpl = frame;

            //////frame.SaveImage("test1.bmp");

            CogImageFileTool ImageFile = new CogImageFileTool();

            ImageFile.Operator.Open("test.bmp", CogImageFileModeConstants.Read);
            ImageFile.Run();

            //cogDisplay1.Image = ImageFile.OutputImage as CogImage24PlanarColor;

            cogDisplay2.Image = ImageFile.OutputImage; 

            ////Bitmap bitmap = frame.ToBitmap();

            ////CogImage24PlanarColor cogimg = new CogImage24PlanarColor();

            ////ICogImage8RootBuffer m_CogImageRoot_R;
            ////m_CogImageRoot_R = new CogImage8Root();

            ////ICogImage8RootBuffer m_CogImageRoot_G;
            ////m_CogImageRoot_G = new CogImage8Root();

            ////ICogImage8RootBuffer m_CogImageRoot_B;
            ////m_CogImageRoot_B = new CogImage8Root();

            ////Bitmap rbmp = new Bitmap(bitmap);
            ////Bitmap gbmp = new Bitmap(bitmap);
            ////Bitmap bbmp = new Bitmap(bitmap);

            //////red green blue image
            ////for (int y = 0; y < bitmap.Height; y++)
            ////{
            ////    for (int x = 0; x < bitmap.Width; x++)
            ////    {
            ////        //get pixel value
            ////        Color p = bitmap.GetPixel(x, y);

            ////        //extract ARGB value from p
            ////        int a = p.A;
            ////        int r = p.R;
            ////        int g = p.G;
            ////        int b = p.B;

            ////        //set red image pixel
            ////        rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

            ////        //set green image pixel
            ////        gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

            ////        //set blue image pixel
            ////        bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

            ////    }
            ////}

            ////BitmapData bmpData = rbmp.LockBits(new Rectangle(0, 0, rbmp.Width, rbmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            ////IntPtr scan0 = bmpData.Scan0;
            ////m_CogImageRoot_R.Initialize(bitmap.Width, bitmap.Height, (IntPtr)scan0, bitmap.Width, null);

            ////bmpData = gbmp.LockBits(new Rectangle(0, 0, gbmp.Width, gbmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            ////scan0 = bmpData.Scan0;
            ////m_CogImageRoot_G.Initialize(bitmap.Width, bitmap.Height, (IntPtr)scan0, bitmap.Width, null);

            ////bmpData = bbmp.LockBits(new Rectangle(0, 0, bbmp.Width, bbmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            ////scan0 = bmpData.Scan0;
            ////m_CogImageRoot_B.Initialize(bitmap.Width, bitmap.Height, (IntPtr)scan0, bitmap.Width, null);

            ////cogimg.SetRoots(m_CogImageRoot_R, m_CogImageRoot_G, m_CogImageRoot_B);

            //cogDisplay1.Image = cogimg.Copy(CogImageCopyModeConstants.CopyPixels);

            //cogDisplay1.Image = frame as CogImage24PlanarColor();
            //pictureBoxIpl1.ImageIpl = frame;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            im_gray = new Mat();
            im_gray = Cv2.ImRead("test.bmp", ImreadModes.Grayscale);

            //frame = im_gray;
            //Camera_Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cx = cogROI.CenterX;
            double cy = cogROI.CenterY;
            double dWidth = cogROI.Width;
            double dHeight = cogROI.Height;

            int ConnerX = Convert.ToInt16(cx - (dWidth / 2));
            int ConnerY = Convert.ToInt16(cy - (dHeight / 2));

            roiStartPoint.X = ConnerX;
            roiStartPoint.Y = ConnerY;

            Rect rect = new Rect(ConnerX, ConnerY, Convert.ToInt16(dWidth), Convert.ToInt16(dHeight));
            
            try
            {
                Canny = im_gray.SubMat(rect);

                pictureBoxIpl2.ImageIpl = Canny;
            }
            catch { }
            
        }

        private void pictureBoxIpl1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            pStart = me.Location;             

            //textBox1.Text = pStart.X.ToString();
            //textBox2.Text = pStart.Y.ToString();
        }

        private void pictureBoxIpl1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            pEnd = me.Location;

            //textBox3.Text = pEnd.X.ToString();
            //textBox4.Text = pEnd.Y.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cogDisplay2.InteractiveGraphics.Clear();
            cogDisplay2.StaticGraphics.Clear();

            cogDisplay2.InteractiveGraphics.Add(cogROI, "", false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            blobcontour = new Mat();

            //blobcontour = Binary(roi);

            FindBlob(roi);

            pictureBoxIpl1.ImageIpl = roi;
        }

        public Mat Binary(Mat src)
        {
            var srcImage = src;
            
            var binaryImage = new Mat(srcImage.Size(), MatType.CV_8UC1);

            //Cv2.CvtColor(srcImage, binaryImage, ColorConversionCodes.BGRA2GRAY);
            Cv2.Threshold(binaryImage, src, thresh: 128, maxval: 255, type: ThresholdTypes.Binary);

            var detectorParams = new SimpleBlobDetector.Params
            {
                MinDistBetweenBlobs = 10, // 10 pixels between blobs
                //MinRepeatability = 1,

                //MinThreshold = 100,
                //MaxThreshold = 255,
                //ThresholdStep = 5,

                FilterByArea = false,
                //FilterByArea = true,
                MinArea = 0.001f, // 10 pixels squared
                //MaxArea = 500,

                FilterByCircularity = false,
                //FilterByCircularity = true,
                //MinCircularity = 0.001f,

                FilterByConvexity = false,
                //FilterByConvexity = true,
                //MinConvexity = 0.001f,
                //MaxConvexity = 10,

                FilterByInertia = false,
                //FilterByInertia = true,
                //MinInertiaRatio = 0.001f,

                FilterByColor = false
                //FilterByColor = true,
                //BlobColor = 255 // to extract light blobs
            };
            var simpleBlobDetector = SimpleBlobDetector.Create(detectorParams);
            var keyPoints = simpleBlobDetector.Detect(binaryImage);

            Console.WriteLine("keyPoints: {0}", keyPoints.Length);
            foreach (var keyPoint in keyPoints)
            {
                Console.WriteLine("X: {0}, Y: {1}", keyPoint.Pt.X, keyPoint.Pt.Y);
            }

            var imageWithKeyPoints = new Mat();
            Cv2.DrawKeypoints(
                    image: binaryImage,
                    keypoints: keyPoints,
                    outImage: imageWithKeyPoints,
                    color: Scalar.FromRgb(255, 0, 0),
                    flags: DrawMatchesFlags.DrawRichKeypoints);

            binaryImage.SaveImage("test-greyimage.bmp");

            Mat ms = new Mat("test-greyimage.bmp", ImreadModes.Grayscale);
            ms = ms.Canny(75, 200, 3, true);

            Window window = new Window("viewer", WindowMode.FreeRatio);
            window.Resize(ms.Width, ms.Height);
            window.ShowImage(ms);

            //Mat yellow = new Mat();
            //Mat dst = binaryImage.Clone();

            //OpenCvSharp.Point[][] contours;
            //HierarchyIndex[] hierarchy;

            //Mat canny = new Mat();

            //canny = canny.Canny(75, 200, 3, true);

            //Cv2.InRange(src, new Scalar(0, 127, 127), new Scalar(100, 255, 255), yellow);
            //Cv2.FindContours(canny, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxTC89KCOS);

            //List<OpenCvSharp.Point[]> new_contours = new List<OpenCvSharp.Point[]>();
            //foreach (OpenCvSharp.Point[] p in contours)
            //{
            //    double length = Cv2.ArcLength(p, true);
            //    if (length > 100)
            //    {
            //        new_contours.Add(p);
            //    }
            //}

            //Cv2.DrawContours(dst, new_contours, -1, new Scalar(255, 0, 0), 2, LineTypes.AntiAlias, null, 1);
            //Cv2.ImShow("dst", dst);
        
            return imageWithKeyPoints;            
        }

        public void FindBlob(Mat src)
        {
            var srcImage = src;

            //var binaryImage = new Mat(srcImage.Size(), MatType.CV_8UC1);

            Window window = new Window("Orignal", WindowMode.FreeRatio);
            window.Resize(srcImage.Width, srcImage.Height);
            window.ShowImage(srcImage);

            Mat y = new Mat();

            Cv2.Threshold(srcImage, y, thresh: 100, maxval: 255, type: ThresholdTypes.Binary);
            window = new Window("threshold", WindowMode.FreeRatio);
            window.Resize(y.Width, y.Height);
            window.ShowImage(y);


            //double ccMin, ccMax;
            //findContours(y, contours, hierarchy, RETR_TREE, CHAIN_APPROX_SIMPLE);
            //Mat c = Mat::zeros(img.size(), CV_8U);
            //for (int i = 0; i < contours.size(); i++)
            //{
            //    cout << i << " = " << hierarchy[i] << "\n";
            //}
            //for (int i = 0; i < contours.size(); i++)
            //{
            //    drawContours(c, contours, i, Scalar(255), 1, LINE_8, hierarchy, 0);
            //    putText(c, format("%d", i), contours[i][0], FONT_HERSHEY_SIMPLEX, 0.5, Scalar(255));
            //}
            //imshow("ctr", c);
            //imwrite("c.png", c);
            //waitKey(0);
        }

        private void imageOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strFileName;

            CogImageFileTool ImageFile = new CogImageFileTool();

            OpenFileDialog OpenFile = new OpenFileDialog();

            OpenFile.DefaultExt = "bmp";
            OpenFile.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";

            OpenFile.ShowDialog();

            if (OpenFile.FileName.Length > 0)
            {                
                strFileName = OpenFile.FileName;

                dstImg = null;

                try
                {
                    using (__OpenCV CV = new __OpenCV())
                    {
                        srcImg = CV.ReadImage(strFileName);
                    }
                }
                catch
                {

                }

                dstImg = srcImg;
                //PictureBox 컨트롤에 넣을 이미지 경로\이미지이름 추가

                System.Drawing.Image img = System.Drawing.Image.FromFile(strFileName);

                pictureBox1.BackColor = Color.DimGray;

                pictureBox1.Image = img.GetThumbnailImage(img.Width, img.Height, null, IntPtr.Zero);

                mBitmap = (Bitmap)img;

                listBox1.Items.Add("이미지의 Width : " + mBitmap.Width);
                listBox1.Items.Add("이미지의 Height : " + mBitmap.Height);              

                Master = Cv2.ImRead("C:\\Users\\vinos\\Desktop\\master.bmp", ImreadModes.AnyColor);    

                ImageFile.Operator.Open(strFileName, CogImageFileModeConstants.Read);
                ImageFile.Run();

                cogDisplay2.Image = ImageFile.OutputImage;
            }                   
        }

        /// <summary>
        /// 그림파일오픈창을 로드후 해당 파일의 FullPath를 가져온다.
        /// </summary>
        /// <returns>파일의 FullPath 파일이 없거나 선택을 안할경우 ""를 리턴</returns>
        public Mat ShowFileOpenDialog()
        {
            //파일오픈창 생성 및 설정
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "파일 오픈 예제창";
            ofd.FileName = "test";
            ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp; | 모든 파일 (*.*) | *.*";

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = ofd.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = ofd.FileName;
                //File경로만 가지고 온다.
                string filePath = fileFullName.Replace(fileName, "");
                
                Mat src = Cv2.ImRead(fileFullName, ImreadModes.AnyColor);

                Origin = src;
                                
                return src;
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                return null;
            }

            return null;
        }

        private void convertGreyImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat im_gray = Origin.CvtColor(ColorConversionCodes.BGR2GRAY);            

            pictureBoxIpl2.ImageIpl = im_gray;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void contoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Binary(pictureBoxIpl1.ImageIpl);
        }

        public Mat Contour(Mat src)
        {
            

            //bin = new Mat(src, ImreadModes.Grayscale);

            //Mat result = new Mat();

            //Cv2.CvtColor(src, bin, ColorConversionCodes.BGRA2GRAY);

            Canny = Canny.Canny(75, 200, 3, true);

            //Cv2.ImShow("Result", Canny);

            OpenCvSharp.Point testPoint = new OpenCvSharp.Point();
            OpenCvSharp.Point[][] contours0;
            HierarchyIndex[] hierarchies;

            InputArray ia;

            Cv2.FindContours(Canny, out contours0, out hierarchies, RetrievalModes.External, ContourApproximationModes.ApproxSimple, testPoint);

            for(int n = 0; n < contours0.Length; n++)
            {
                double peri = Cv2.ArcLength(contours0[n], true);

                OpenCvSharp.Point[] pp = Cv2.ApproxPolyDP(contours0[n], 0.02 * peri, true);

                RotatedRect rr = Cv2.MinAreaRect(pp);

                double areaRatio = Math.Abs(Cv2.ContourArea(contours0[n], false) / (rr.Size.Width * rr.Size.Height));

                if(pp.Length == 4)
                {
                    Cv2.DrawContours(CannyColor, contours0, n, Scalar.Red, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);
                }
                //else if(pp.Length > 4)
                //{
                //    Cv2.DrawContours(CannyColor, contours0, n, Scalar.Yellow, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);
                //}
                else
                {
                    Cv2.DrawContours(CannyColor, contours0, n, Scalar.Green, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);
                }
            }

            Cv2.ImShow("윤곽선", CannyColor);

            Cv2.WaitKey(0);

            Cv2.DestroyAllWindows();

            //bin = new Mat(src.Size(), MatType.CV_8UC1);

            //Cv2.Threshold(bin, bin, thresh: 180, maxval: 255, type: ThresholdTypes.Binary);

            //Cv2.FindContours(bin, out OpenCvSharp.Point[][] contour, out HierarchyIndex[] hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple); 
            //for (int i = 0; i < contour.Length; i++) 
            //{
            //    Cv2.DrawContours(result, contour, i, Scalar.Green, 2, LineTypes.AntiAlias, hierarchy); 
            //}
            //for (int i = 0; i < contour.Length; i++) 
            //{ 
            //    Rect rect = Cv2.BoundingRect(contour[i]); 
            //    Cv2.Rectangle(result, new OpenCvSharp.Point(rect.X, rect.Y), new OpenCvSharp.Point(rect.X + rect.Width, rect.Y + rect.Height), Scalar.Yellow, 2, LineTypes.AntiAlias); 
            //}
            //for (int i = 0; i < contour.Length; i++) 
            //{ 
            //    RotatedRect rect = Cv2.MinAreaRect(contour[i]); 
            //    for (int j = 0; j < 4; j++) 
            //    { 
            //        Cv2.Line(result, new OpenCvSharp.Point(rect.Points()[j].X, rect.Points()[j].Y), new OpenCvSharp.Point(rect.Points()[(j + 1) % 4].X, rect.Points()[(j + 1) % 4].Y), Scalar.Red, 2, LineTypes.AntiAlias);
            //    }
            //}
            //Cv2.ImShow("result", result); 

            //Cv2.WaitKey(0); 

            //Cv2.DestroyAllWindows();        

            return bin;
        }

        private void dialteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dilatateChangeValue = textBox_DilatateChangeValue.Text;
            var dilatateKernnelValue = textBox_DilatateKernnelValue.Text;
            
            __OpenCV CV = new __OpenCV();

            CV.dialte(srcImg, Convert.ToInt32(dilatateChangeValue), Convert.ToInt32(dilatateChangeValue));            
        }

        private void erodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ErodeKernnelValue = textBox_ErodeKernnelValue.Text;
            var ErodeChangeValue = textBox_ErodeChangeValue.Text;

            Mat element = Cv2.GetStructuringElement(MorphShapes.Ellipse, new OpenCvSharp.Size(Convert.ToInt32(ErodeKernnelValue), Convert.ToInt32(ErodeChangeValue)));
            Cv2.MorphologyEx(dstImg, dstImg, MorphTypes.Erode, element, iterations: Convert.ToInt32(ErodeKernnelValue));

            Cv2.ImShow("Erode", dstImg);

            Cv2.WaitKey(0);

            Cv2.DestroyAllWindows();

            pictureBoxIpl2.ImageIpl = dstImg;           
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 사각형검출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rectCount = 0;

            var MinThreshold = textBox_MinThreshold.Text;
            var MaxThreshold = textBox_MaxThreshold.Text;

            Canny = dstImg.Canny(Convert.ToDouble(MinThreshold), Convert.ToDouble(MaxThreshold), 3, true);            

            OpenCvSharp.Point testPoint = new OpenCvSharp.Point();
            OpenCvSharp.Point[][] contours0;
            HierarchyIndex[] hierarchies;

            InputArray ia;

            Cv2.ImShow("Canny", Canny);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
            //Cv2.FindContours(Canny, out contours0, out hierarchies, RetrievalModes.External, ContourApproximationModes.ApproxSimple, testPoint);

            Cv2.FindContours(Canny, out contours0, out hierarchies, RetrievalModes.External, ContourApproximationModes.ApproxSimple, testPoint);

            Console.WriteLine(contours0.Length);

            listBox1.Items.Clear();

            var dvalue = Convert.ToDouble(textBox1.Text);
                       
            for (int n = 0; n < contours0.Length; n++)
            {
                double peri = Cv2.ArcLength(contours0[n], true);

                OpenCvSharp.Point[] pp = Cv2.ApproxPolyDP(contours0[n], dvalue * peri, true);

                RotatedRect rr = Cv2.MinAreaRect(pp);

                double areaRatio = Math.Abs(Cv2.ContourArea(contours0[n], false) / (rr.Size.Width * rr.Size.Height));

                double area = Cv2.ContourArea(contours0[n]);

                double judgeArea = Convert.ToDouble(textBox_contourArea.Text);

                if (area > judgeArea)
                {
                    listBox1.Items.Add(area.ToString());

                    Rect boundingRect = Cv2.BoundingRect(pp);

                    int rectSizeW = boundingRect.Size.Width;
                    int rectSizeH = boundingRect.Size.Height;

                    int rectSize = rectSizeW * rectSizeH;

                    listBox1.Items.Add(string.Format(n + " 번째 사각형 크기 : " + rectSize));

                    CvBlobs Blob = new CvBlobs();

                    Mat roi = Canny.SubMat(boundingRect);

                    Mat result = new Mat(roi.Size(), MatType.CV_8UC3);

                    Blob.RenderBlobs(roi, result);

                    //Cv2.ImShow("윤곽선", result);

                    //Cv2.WaitKey(0);

                    //Cv2.DestroyAllWindows();

                    double cvRoiStartPointX = Convert.ToDouble(roiStartPoint.X);

                    if (pp.Length == 4)
                    {
                        //for(int i = 0; i < contours0[n].Length; i++)
                        //{
                        //    Cv2.DrawContours(CannyColor, contours0[n][i]+ roiStartPoint + cvRoiStartPointX, n, Scalar.Red, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);
                        //}

                        //Cv2.DrawContours(Origin, contours0, n, Scalar.Red, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);

                        if(rectSizeW < 10 || rectSizeH < 10)
                        {

                        }
                        else
                        {
                            //Cv2.Rectangle(dstImg, boundingRect, Scalar.Black, -1);

                            if(checkBox_LastDraw.Checked)
                            {
                                Cv2.DrawContours(dstImg, contours0, n, Scalar.Red, 3, LineTypes.AntiAlias, hierarchies, 100, testPoint);

                                Moments mmt = Cv2.Moments(contours0[n]);
                                double cx = mmt.M10 / mmt.M00, cy = mmt.M01 / mmt.M00;
                                Cv2.Circle(dstImg, new OpenCvSharp.Point(cx, cy), 3, Scalar.Red, 3, LineTypes.AntiAlias);

                                Cv2.PutText(dstImg, "center", new Point(cx + 10, cy + 10), HersheyFonts.Italic, 2, Scalar.White, 3, LineTypes.AntiAlias);
                            }
                            

                            rectCount += 1;
                        }                        
                    }
                    else if (pp.Length == 6)
                    {
                        Cv2.DrawContours(dstImg, contours0, n, Scalar.Green, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);

                        //Cv2.Rectangle(dstImg, boundingRect, Scalar.Cyan, 2);
                        Rect bound = new Rect();
                        bound.X = boundingRect.X;
                        bound.Y = boundingRect.Y;
                        bound.Height = boundingRect.Height + 5;
                        bound.Width = boundingRect.Width + 5;

                        //Cv2.Rectangle(dstImg, bound, Scalar.Black, -1);

                        //if (checkBox_LastDraw.Checked)
                        //{
                        //    Scalar sColor = new Scalar(0, 0, 0);

                        //    //Cv2.Rectangle(dstImg, boundingRect, Scalar.Black, -1);

                        //    OpenCvSharp.Point startP = boundingRect.TopLeft;

                        //    OpenCvSharp.Point endP = boundingRect.BottomRight;

                        //    Moments mmt = Cv2.Moments(contours0[n]);
                        //    double cx = mmt.M10 / mmt.M00, cy = mmt.M01 / mmt.M00;
                        //}

                        //listBox1.Items.Add(string.Format("시작 X 좌표 : {0:F2}, 시작 Y 좌표 : {1:F2}, 끝 X 좌표 : {2:F2}, 끝 Y 좌표 : {3:F2}", startP.X, startP.Y, endP.X, endP.Y));
                    }
                    else
                    {
                        Cv2.DrawContours(dstImg, contours0, n, Scalar.Green, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);

                        //Cv2.Rectangle(dstImg, boundingRect, Scalar.Cyan, 2);
                        Rect bound = new Rect();
                        bound.X = boundingRect.X;
                        bound.Y = boundingRect.Y;
                        bound.Height = boundingRect.Height + 5;
                        bound.Width = boundingRect.Width + 5;

                        //Cv2.Circle(Origin, pp, 3, Scalar.Red, -1, LineTypes.AntiAlias);

                        //Cv2.Rectangle(dstImg, bound, Scalar.Black, -1);

                        //if (checkBox_LastDraw.Checked)
                        //{
                        //    Scalar sColor = new Scalar(0, 0, 0);

                        //    //Cv2.Rectangle(dstImg, boundingRect, Scalar.Black, -1);

                        //    OpenCvSharp.Point startP = boundingRect.TopLeft;

                        //    OpenCvSharp.Point endP = boundingRect.BottomRight;

                        //    Moments mmt = Cv2.Moments(contours0[n]);
                        //    double cx = mmt.M10 / mmt.M00, cy = mmt.M01 / mmt.M00;
                        //}

                        //Cv2.Circle(Origin, new OpenCvSharp.Point(cx, cy), 3, Scalar.Red, -1, LineTypes.AntiAlias);

                        //listBox1.Items.Add(string.Format("시작 X 좌표 : {0:F2}, 시작 Y 좌표 : {1:F2}, 끝 X 좌표 : {2:F2}, 끝 Y 좌표 : {3:F2}", startP.X, startP.Y, endP.X, endP.Y));
                    }
                }
            }

            
            Cv2.ImShow("윤곽선", dstImg);

            Cv2.WaitKey(0);

            Cv2.DestroyAllWindows();

            //listBox1.Items.Clear();
            listBox1.Items.Add(string.Format("검출된 사각형의 갯수 : " + rectCount));
        }

        private void 그레이ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dstImg != null)
            {
                GrayMaster = dstImg;

                pictureBoxIpl2.ImageIpl = dstImg;
            }      
        }

        private void 내부픽셀별Gray값뽑기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void harrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180;
        }

        private double RadianToDegree(double angle)
        {
            return angle / 180 * Math.PI;
        }

        private void blobLabelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cv2.CvtColor(dstImg, dstImg, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(dstImg, dstImg, 0, 255, ThresholdTypes.Otsu);
            Cv2.ImShow("src", dstImg);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();

            int count = 0;

            Mat result = new Mat(Origin.Size(), MatType.CV_8UC3);        
            CvBlobs blobs = new CvBlobs(); 
            blobs.Label(dstImg); 
            blobs.RenderBlobs(dstImg, result);

            Cv2.ImShow("result", result);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();

            int blobarea = Convert.ToInt32(textBox_BlobMinArea.Text);

            foreach (var item in blobs) 
            {
                CvBlob b = item.Value;
                
                if(b.Area > blobarea)
                {
                    
                    Rect bound = new Rect(Convert.ToInt32(b.Centroid.X) - (b.Rect.Width / 2), 
                                            Convert.ToInt32(b.Centroid.Y) - (b.Rect.Height / 2), 
                                            b.Rect.Width, 
                                            b.Rect.Height);
                    int boundArea = Convert.ToInt32((bound.Width * bound.Height) * 0.6);
                    if(b.Area > boundArea)
                    {   
                        double dAngle = RadianToDegree(b.Angle());
                        label_BlobAngle.Text = dAngle.ToString();
                        if(b.Rect.Width > Convert.ToInt32(textBox_MinWidthBlob.Text))
                        {
                            if(b.Rect.Height > Convert.ToInt32(textBox_MinHeightBlob.Text))
                            {
                                count++;
                                Cv2.Rectangle(dstImg, bound, Scalar.Red, 2);
                                Cv2.Circle(dstImg, new Point(b.Centroid.X, b.Centroid.Y), 3, Scalar.Red, -1, LineTypes.AntiAlias);
                                Cv2.PutText(dstImg, count.ToString(), new Point(b.Centroid.X, b.Centroid.Y), HersheyFonts.HersheyComplex, 1, Scalar.Yellow, 2, LineTypes.AntiAlias);
                                //Cv2.Rectangle(GrayMaster, bound, Scalar.Black, -1);
                            }
                        }


                        //count++;
                        //Cv2.Circle(dstImg, new Point(b.Centroid.X, b.Centroid.Y), 3, Scalar.Red, -1, LineTypes.AntiAlias);
                        //Cv2.PutText(dstImg, count.ToString(), new Point(b.Centroid.X, b.Centroid.Y), HersheyFonts.HersheyComplex, 1, Scalar.Yellow, 2, LineTypes.AntiAlias);
                        //Cv2.Rectangle(dstImg, bound, Scalar.Black, -1);
                    }
                    else
                    {
                        
                        //Cv2.Inpaint(dstImg, b., dstImg, 4, InpaintMethod.Telea);
                        //Cv2.FloodFill(dstImg, b.Clone, Scalar.Black);
                    }
                    //bound.X = Convert.ToInt32(b.Centroid.X);
                    //bound.Y = Convert.ToInt32(b.Centroid.Y);
                    //bound.Width = b.Rect.Width - 20;
                    //bound.Height = b.Rect.Height - 20;



                    //Cv2.Rectangle(dstImg, bound, Scalar.Black, -1);

                    //Cv2.Circle(dstImg, new Point(b.Centroid.X, b.Centroid.Y), 3, Scalar.Red, -1, LineTypes.AntiAlias);
                    //Cv2.Circle(result, b.Contour.StartingPoint, 4, Scalar.Red, 2, LineTypes.AntiAlias);
                    //Cv2.PutText(dstImg, count.ToString(), new Point(b.Centroid.X, b.Centroid.Y), HersheyFonts.HersheyComplex, 1, Scalar.Yellow, 2, LineTypes.AntiAlias);
                }                
            }

            //dstImg = GrayMaster;

            listBox1.Items.Add("Blob 갯수 : " + count);
            Cv2.ImShow("result", dstImg); 
            Cv2.WaitKey(0); 
            Cv2.DestroyAllWindows();

            Cv2.ImWrite("C:\\Users\\vinos\\Desktop\\test111111.bmp", dstImg);

            pictureBoxIpl3.ImageIpl = dstImg;
        }

        private void 흑백반전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dstImg = new Mat(Origin.Size(), MatType.CV_8UC3);

            Cv2.BitwiseNot(dstImg, dstImg);
            Cv2.BitwiseNot(GrayMaster, GrayMaster);

            Cv2.ImShow("흑백 반전", dstImg);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BlurSize = Convert.ToInt32(textBox_BlurParam.Text);
            Cv2.MedianBlur(dstImg, dstImg, BlurSize);        
            new Window("dst image", dstImg);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }

        private void 원검출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var circleLength = textBox_CircleLength.Text;
            var HufThreshold = textBox_HufThreshold.Text;
            var minDistance = textBox_MinDistance.Text;
            var HistoValue = textBox_HistogramValue.Text;

            CircleSegment[] circleSegment;

            //dstImg = new Mat(dstImg.Size(), MatType.CV_8UC1);            

            circleSegment = Cv2.HoughCircles(dstImg, HoughMethods.Gradient, 1, Convert.ToDouble(minDistance), Convert.ToDouble(HufThreshold), Convert.ToDouble(HistoValue), 0, Convert.ToInt32(circleLength));
            //dstImg = new Mat(dstImg.Size(), Origin.Type());

            Scalar pColor = new Scalar(0, 0, 255);
            Scalar sColor = new Scalar(0, 0, 0);

            for (int i = 0; i < circleSegment.Count(); i++)
            {
                //Cv2.Circle(Origin, (int)circleSegment[i].Center.X, (int)circleSegment[i].Center.Y, (int)circleSegment[i].Radius, pColor, 2, LineTypes.AntiAlias);
                //加强圆心显示
                Cv2.Circle(dstImg, (int)circleSegment[i].Center.X, (int)circleSegment[i].Center.Y, (int)circleSegment[i].Radius + 3, sColor, -1);
            }

            Cv2.ImShow("dstImg", dstImg);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            
        }

        public Mat HoughLineDetect(Mat dstImg, double MinThreshold, double MaxThreshold, int threshold, double houghLineMinLength, double houghLineAllowInterval)
        {
            try
            {
                Mat edges = new Mat();

                dstImg = dstImg.Canny(MinThreshold, MaxThreshold, 3, true);

                //HoughLinesP
                LineSegmentPoint[] segHoughP = Cv2.HoughLinesP(dstImg, 1, Math.PI / 180, threshold, houghLineMinLength, houghLineAllowInterval);

                Mat imageOutP = dstImg.EmptyClone();

                foreach (LineSegmentPoint s in segHoughP)
                    imageOutP.Line(s.P1, s.P2, Scalar.White, 3, LineTypes.AntiAlias, 0);

                using (new Window("Edges", WindowMode.AutoSize, dstImg))
                using (new Window("HoughLinesP", WindowMode.AutoSize, imageOutP))
                {
                    Window.WaitKey(0);
                    Cv2.DestroyAllWindows();
                }

                dstImg = imageOutP;

                return dstImg;
            }
            catch
            {
                return null;
            }            
        }


        private void 직선검출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double DiffX, Diffy;

            Mat edges = new Mat();

            var threshold = textBox_HoughThreshold.Text;
            var houghLineMinLength = textBox_HoughLineMinLength.Text;
            var houghLineAllowInterval = textBox_HoughLineAllowInterval.Text;

            var MinThreshold = textBox_MinThreshold.Text;
            var MaxThreshold = textBox_MaxThreshold.Text;

            dstImg = dstImg.Canny(Convert.ToDouble(MinThreshold), Convert.ToDouble(MaxThreshold), 3, true);

            //HoughLinesP
            LineSegmentPoint[] segHoughP = Cv2.HoughLinesP(dstImg, 1, Math.PI / 180, Convert.ToInt32(threshold), Convert.ToDouble(houghLineMinLength), Convert.ToDouble(houghLineAllowInterval));

            Mat imageOutP = dstImg.EmptyClone();

            foreach (LineSegmentPoint s in segHoughP)
                imageOutP.Line(s.P1, s.P2, Scalar.White, 3, LineTypes.AntiAlias, 0);

            //foreach (LineSegmentPoint s in segHoughP)
            //{
            //    DiffX = Math.Abs(s.P2.X - s.P1.X);
            //    Diffy = Math.Abs(s.P2.Y - s.P1.Y);
            //    if(DiffX > 100)
            //    {
            //        if(Diffy > 100)
            //        {
            //            imageOutP.Line(s.P1, s.P2, Scalar.White, 3, LineTypes.AntiAlias, 0);
            //        }
            //    }                
            //}


            using (new Window("Edges", WindowMode.AutoSize, dstImg))
            using (new Window("HoughLinesP", WindowMode.AutoSize, imageOutP))
            //using (new Window("HoughLinesP", WindowMode.AutoSize, imageOutP))
            {
                Window.WaitKey(0);
                Cv2.DestroyAllWindows();
            }

            //dstImg = imageOutP;

            dstImg = imageOutP;

        }

        private void 매칭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Mat temp = new Mat(@"master.bmp"))
            using (Mat result = new Mat())
            {
                Mat covertImage = new Mat(temp.Size(), MatType.CV_8UC1);

                // 이미지 템플릿 매치
                Cv2.MatchTemplate(dstImg, covertImage, result, TemplateMatchModes.CCoeffNormed);

                // 이미지의 최대/ 최소 위치 겟
                OpenCvSharp.Point minloc, maxloc;
                double minval, maxval;
                Cv2.MinMaxLoc(result, out minval, out maxval, out minloc, out maxloc);

                // 타겟 이미지랑 유사 정도 1에 가까울 수록 같음
                var threshold = 0.1;
                if (maxval >= threshold)
                {
                    // 서치된 부분을 빨간 테두리로
                    Rect rect = new Rect(maxloc.X, maxloc.Y, temp.Width, temp.Height);
                    Cv2.Rectangle(dstImg, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);

                    // 표시
                    Cv2.ImShow("template1_show", dstImg);

                }
                else
                {
                    // 낫 매칭
                    MessageBox.Show("못찾았슴돠.");
                }
            }
        }

        private void 캐니엣지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rectCount = 0;

            var MinThreshold = textBox_MinThreshold.Text;
            var MaxThreshold = textBox_MaxThreshold.Text;

            Canny = dstImg.Canny(Convert.ToDouble(MinThreshold), Convert.ToDouble(MaxThreshold), 3, true);

            OpenCvSharp.Point testPoint = new OpenCvSharp.Point();
            OpenCvSharp.Point[][] contours0;
            HierarchyIndex[] hierarchies;

            InputArray ia;

            Cv2.FindContours(Canny, out contours0, out hierarchies, RetrievalModes.External, ContourApproximationModes.ApproxSimple, testPoint);

            Console.WriteLine(contours0.Length);

            listBox1.Items.Clear();

            var dvalue = Convert.ToDouble(textBox1.Text);

            for (int n = 0; n < contours0.Length; n++)
            {
                double peri = Cv2.ArcLength(contours0[n], true);

                OpenCvSharp.Point[] pp = Cv2.ApproxPolyDP(contours0[n], dvalue * peri, true);

                RotatedRect rr = Cv2.MinAreaRect(pp);

                double areaRatio = Math.Abs(Cv2.ContourArea(contours0[n], false) / (rr.Size.Width * rr.Size.Height));

                double area = Cv2.ContourArea(contours0[n]);

                double judgeArea = Convert.ToDouble(textBox_contourArea.Text);

                if (area > judgeArea)
                {
                    listBox1.Items.Add(area.ToString());

                    Rect boundingRect = Cv2.BoundingRect(pp);

                    int rectSizeW = boundingRect.Size.Width;
                    int rectSizeH = boundingRect.Size.Height;

                    int rectSize = rectSizeW * rectSizeH;

                    listBox1.Items.Add(string.Format(n + " 번째 사각형 크기 : " + rectSize));

                    CvBlobs Blob = new CvBlobs();

                    Mat roi = Canny.SubMat(boundingRect);

                    Mat result = new Mat(roi.Size(), MatType.CV_8UC3);

                    Blob.RenderBlobs(roi, result);

                    //Cv2.ImShow("윤곽선", result);

                    //Cv2.WaitKey(0);

                    //Cv2.DestroyAllWindows();

                    double cvRoiStartPointX = Convert.ToDouble(roiStartPoint.X);

                    Cv2.FillConvexPoly(dstImg, pp, Scalar.Black, LineTypes.AntiAlias, 0);                    
                }
            }


            Cv2.ImShow("윤곽선", dstImg);

            Cv2.WaitKey(0);

            Cv2.DestroyAllWindows();

            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format("검출된 사각형의 갯수 : " + rectCount));
        }

        private unsafe void 하얀색선긋기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bytes2;

            Cv2.ImEncode(".bmp", dstImg, out bytes2);

            int blackCnt = 0;
            int blackStartPoint = 0;            
            
            for(int x = 0; x < bytes2.Length; x++)
            {
                if(bytes2.ElementAt(x) == 0)
                {
                    blackCnt++;
                    blackStartPoint = x;
                    break;
                }
                if(blackCnt < 1000)
                {
                    //bytes2.ElementAt
                }
                Console.WriteLine(bytes2.ElementAt(x));
            }
        }

        private void 사각형만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rectCount = 0;

            var MinThreshold = textBox_MinThreshold.Text;
            var MaxThreshold = textBox_MaxThreshold.Text;

            Canny = dstImg.Canny(Convert.ToDouble(MinThreshold), Convert.ToDouble(MaxThreshold), 3, true);

            OpenCvSharp.Point testPoint = new OpenCvSharp.Point();
            OpenCvSharp.Point[][] contours0;
            HierarchyIndex[] hierarchies;

            InputArray ia;

            Cv2.ImShow("Canny", Canny);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
            //Cv2.FindContours(Canny, out contours0, out hierarchies, RetrievalModes.External, ContourApproximationModes.ApproxSimple, testPoint);

            Cv2.FindContours(Canny, out contours0, out hierarchies, RetrievalModes.External, ContourApproximationModes.ApproxNone, testPoint);

            Console.WriteLine(contours0.Length);

            listBox1.Items.Clear();
            
            var dvalue = Convert.ToDouble(textBox1.Text);

            for (int n = 0; n < contours0.Length; n++)
            {
                double peri = Cv2.ArcLength(contours0[n], true);

                OpenCvSharp.Point[] pp = Cv2.ApproxPolyDP(contours0[n], dvalue * peri, true);

                RotatedRect rr = Cv2.MinAreaRect(pp);

                //Cv2.DrawContours(dstImg, contours0, n, Scalar.Red, 2, LineTypes.AntiAlias, hierarchies, 100, rr);

                double areaRatio = Math.Abs(Cv2.ContourArea(contours0[n], false) / (rr.Size.Width * rr.Size.Height));

                double area = Cv2.ContourArea(contours0[n]);

                double judgeArea = Convert.ToDouble(textBox_contourArea.Text);

                if (area > judgeArea)
                {
                    listBox1.Items.Add(area.ToString());

                    Rect boundingRect = Cv2.BoundingRect(pp);

                    int rectSizeW = Convert.ToInt32(boundingRect.Size.Width * 0.8);
                    int rectSizeH = Convert.ToInt32(boundingRect.Size.Height * 0.8);

                    int rectSize = rectSizeW * rectSizeH;

                    listBox1.Items.Add(string.Format(n + " 번째 사각형 크기 : " + rectSize));

                    CvBlobs Blob = new CvBlobs();

                    Mat roi = Canny.SubMat(boundingRect);

                    Mat result = new Mat(roi.Size(), MatType.CV_8UC3);

                    //Blob.RenderBlobs(roi, result);

                    //Cv2.ImShow("윤곽선", result);

                    //Cv2.WaitKey(0);

                    //Cv2.DestroyAllWindows();

                    double cvRoiStartPointX = Convert.ToDouble(roiStartPoint.X);

                    if (pp.Length == 4)
                    {
                        //for(int i = 0; i < contours0[n].Length; i++)
                        //{
                        //    Cv2.DrawContours(CannyColor, contours0[n][i]+ roiStartPoint + cvRoiStartPointX, n, Scalar.Red, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);
                        //}

                        //Cv2.DrawContours(Origin, contours0, n, Scalar.Red, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);

                        if (rectSizeW < 200 || rectSizeH < 200)
                        {

                        }
                        else
                        {
                            //Cv2.Rectangle(dstImg, boundingRect, Scalar.Black, -1);

                            //if (checkBox_LastDraw.Checked)
                            //{
                            Cv2.DrawContours(Master, contours0, n, Scalar.Red, 2, LineTypes.AntiAlias, hierarchies, 100, testPoint);

                            Moments mmt = Cv2.Moments(contours0[n]);
                            double cx = mmt.M10 / mmt.M00, cy = mmt.M01 / mmt.M00;
                            Cv2.Circle(Master, new OpenCvSharp.Point(cx, cy), 3, Scalar.Red, 2, LineTypes.AntiAlias);

                            Cv2.PutText(Master, "center", new Point(cx + 10, cy + 10), HersheyFonts.Italic, 1, Scalar.White, 1, LineTypes.AntiAlias);
                            //}
                            rectCount += 1;
                            break;                            
                        }
                    }                    
                    else
                    {
                        if (rectSizeW < 200 || rectSizeH < 200)
                        {

                        }
                        else
                        {
                            // 각 꼭지점에 점 찍기
                            //for (int i = 0; i < pp.Length; i++)
                            //{
                            //    Cv2.Circle(Master, pp[i].X, pp[i].Y, 3, Scalar.Red, 2, LineTypes.AntiAlias);
                            //}

                            //Cv2.DrawContours(Master, contours0, n, Scalar.Green, 3, LineTypes.AntiAlias, hierarchies, 100, testPoint);

                            Cv2.DrawContours(Master, contours0, n, Scalar.Black, -1, LineTypes.AntiAlias, hierarchies, 100, testPoint); // 검출된 윤곽선 안을 검은색으로 채우기

                            //Cv2.Rectangle(Master, boundingRect, Scalar.Black, -1);

                            //Rect bound = new Rect();
                            //bound.X = boundingRect.X;
                            //bound.Y = boundingRect.Y;
                            //bound.Height = boundingRect.Height + 5;
                            //bound.Width = boundingRect.Width + 5;

                            //OpenCvSharp.Point startP = boundingRect.TopLeft;

                            //OpenCvSharp.Point endP = boundingRect.BottomRight;

                            Moments mmt = Cv2.Moments(contours0[n]);
                            double cx = mmt.M10 / mmt.M00, cy = mmt.M01 / mmt.M00;

                            //Cv2.Circle(Master, new OpenCvSharp.Point(cx, cy), 3, Scalar.Red, 2, LineTypes.AntiAlias); // 중심 좌표에 원그리기

                            //Cv2.PutText(Master, pp.Length.ToString(), new Point(cx + 10, cy + 10), HersheyFonts.Italic, 1, Scalar.Red, 2, LineTypes.AntiAlias); // 중심 좌표에 꼭지점 갯수 그리기

                            listBox1.Items.Add(string.Format("중심 X 좌표 : {0:F2}, 중심 Y 좌표 : {1:F2}", cx, cy));

                            Cv2.Line(Master, 0, Convert.ToInt32(cy), Master.Width, Convert.ToInt32(cy), Scalar.White, 15, LineTypes.AntiAlias); // 줌싱좌표에 중심선 긋기

                            break;
                        }
                    }
                }

                
            }


            Cv2.ImShow("윤곽선", Master);

            dstImg = Master;

            Cv2.ImWrite("C:\\Users\\vinos\\Desktop\\test1234.bmp", dstImg);

            Cv2.WaitKey(0);

            Cv2.DestroyAllWindows();

            //listBox1.Items.Clear();
            //listBox1.Items.Add(string.Format("검출된 사각형의 갯수 : " + rectCount));
        }

        private void 김중환ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<byte> bt_Res = new List<byte>();

            byte[] bytes2;

            Cv2.ImEncode(".bmp", CannyColor, out bytes2);

            _cut(CannyColor.Height, CannyColor.Width, ref bytes2, ref bt_Res);

            string str_path = "E:\\2D_Image\\Test Image\\";

            string str_name = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            string str_Path_cut_bmp = str_path + str_name + "_cut_b.bmp";

            _b_SaveImage(CannyColor.Height, CannyColor.Width, ref bt_Res, str_Path_cut_bmp);
        }

        private void _cut(int nTlines, int nTwidth, ref byte[] bt_Source, ref List<byte> bt_Res)
        {
            int nCkeck_Black = 400;
            byte[] bt_Data = bt_Source;
            bool b_First = true;
            int nCntbk = 0;
            int nCnt = 0;
            int n_Start_bk = 0;
            int n_End_bk = 0;

            int n_mergy = 0;

            for (int i = 0; i < nTlines; i++)
            {
                for (int j = 0; j < nTwidth; j++)
                {
                    byte bt_item = bt_Data[nCnt];
                    if (bt_item == 0x00) // B
                    {
                        if (b_First)
                        {
                            n_Start_bk = nCnt;
                            b_First = false;
                        }
                        nCntbk++;
                    }
                    else // W
                    {
                        b_First = true;

                        if (bt_item == 0xff && nCntbk > 0 && nCntbk < nCkeck_Black) //화이트라면 ...
                        {
                            // 전부 화이트로 ...
                            n_End_bk = nCnt;
                            // start~ end 까지 0x00
                            //...
                            for (int k = n_Start_bk; k < n_End_bk; k++)
                            {
                                bt_Data[k] = 0xff;
                            }
                            n_mergy++;
                        }
                        else
                        {

                        }
                        nCntbk = 0;
                    }
                    nCnt++;
                }
                b_First = true;
            }

            string str_temp;
            str_temp = string.Format("Mergy Cnt  : [{0}]  ", n_mergy);

            nCnt = 0;
            for (int i = 0; i < nTlines; i++)
            {
                for (int J = 0; J < nTwidth; J++)
                {
                    //   if(bt_Data[nCnt] != 0x8f) bt_Res.Add(0xff);

                    bt_Res.Add(bt_Data[nCnt]);
                    nCnt++;
                }
            }
        }

        private void _b_SaveImage(int nTlines, int nTwidth, ref List<byte> ListImageTemp, string s_Pathname)
        {

            int nColY = nTlines;
            int nColX = nTwidth;
            byte[] bt_Data = ListImageTemp.ToArray();

            Mat matData2 = new Mat(nColY, nColX, MatType.CV_8U, bt_Data);
            Bitmap u_bitmap2 = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(matData2);
            u_bitmap2.Save(s_Pathname, System.Drawing.Imaging.ImageFormat.Bmp);

            Cv2.ImShow("Result", matData2);

            dstImg = matData2;
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }

        private void 엣지확장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TiffConverter cls_tiff = new TiffConverter();

            //string str_path = "G:\\bin data\\sss\\";
            //string str_name = "f13_41_35";
            //string str_Path_bin = str_path + str_name + ".bin";
            //string str_Path_tif = str_path + str_name + ".tif";
            //string str_Path_2bin = str_path + str_name + "_b.tif";
            //string str_Path_bmp = str_path + str_name + "_b.bmp";
            // read 
            int nTlines = 0;
            int nTwidth = 0;
            //List<ushort> ListImageTemp = new List<ushort>();
            //cls_tiff.BinRead(str_Path_bin, ref ListImageTemp, ref nTlines, ref nTwidth);


            List<float> ListImageTemp = new List<float>();
            BinRead_float(str_Path_bin, ref ListImageTemp, ref nTlines, ref nTwidth);


            //// write
            ////   List<ushort> l_data = mshort_ResMergy.ToList();
            //cls_tiff.Save(str_Path_tif, ListImageTemp, nTlines, nTwidth);
            ////.................................................................................

            //      listBox.Items.Add()

            // make bin
            //    float f_SplitData = 1160956360;
            float f_SplitData = float.Parse(textBox_BinParam.Text); //1160902000


            List<byte> ListbtImage = new List<byte>();
            split_fData(ref ListImageTemp, f_SplitData, ref ListbtImage);


            //      cls_tiff.Save(str_Path_2bin, ListbtImage, nTlines, nTwidth);
            List<byte> bt_Res = new List<byte>();
            _cut2(nTlines, nTwidth, ref ListbtImage, ref bt_Res);

            string str_path = "E:\\2D_Image\\Test Image\\";

            string str_name = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            string str_Path_cut_bmp = str_path + str_name + "_cut_b.bmp";

            _b_SaveImage(nTlines, nTwidth, ref bt_Res, str_Path_cut_bmp);

            //....
            //string str_Path_bmp_Rf = str_path + str_name + string.Format("{0}_{1}_x.bmp", 0, f_SplitData);
            //_f_TempImage(nTlines, nTwidth, ref ListImageTemp, f_SplitData, str_Path_bmp_Rf);
        }

        private void _cut2(int nTlines, int nTwidth, ref List<byte> bt_Source, ref List<byte> bt_Res)
        {
            int nCkeck_Black = int.Parse(textBox_CutCnt.Text);
            byte[] bt_Data = bt_Source.ToArray();
            bool b_First = true;
            int nCntbk = 0;
            int nCnt = 0;
            int n_Start_bk = 0;
            int n_End_bk = 0;

            int n_mergy = 0;

            for (int i = 0; i < nTlines; i++)
            {
                for (int j = 0; j < nTwidth; j++)
                {
                    byte bt_item = bt_Data[nCnt];
                    if (bt_item == 0x00) // B
                    {
                        if (b_First)
                        {
                            n_Start_bk = nCnt;
                            b_First = false;
                        }
                        nCntbk++;
                    }
                    else // W
                    {
                        b_First = true;

                        if (bt_item == 0xff && nCntbk > 0 && nCntbk < nCkeck_Black) //화이트라면 ...
                        {
                            // 전부 화이트로 ...
                            n_End_bk = nCnt;
                            // start~ end 까지 0x00
                            //...
                            for (int k = n_Start_bk; k < n_End_bk; k++)
                            {
                                bt_Data[k] = 0xff;
                            }
                            n_mergy++;
                        }
                        else
                        {

                        }
                        nCntbk = 0;
                    }
                    nCnt++;
                }
                b_First = true;
            }

            string str_temp;
            str_temp = string.Format("Mergy Cnt  : [{0}]  ", n_mergy);
            //listBox.Items.Add(str_temp);



            nCnt = 0;
            for (int i = 0; i < nTlines; i++)
            {
                for (int J = 0; J < nTwidth; J++)
                {
                    //   if(bt_Data[nCnt] != 0x8f) bt_Res.Add(0xff);

                    bt_Res.Add(bt_Data[nCnt]);
                    nCnt++;
                }
            }
        }
        private void split_fData(ref List<float> ListImage, float f_SplitData, ref List<byte> ListbtImage)
        {
            int n_Hight = 0;
            int n_Low = 0;

            ListbtImage.Clear();

            byte us_Data = 0;
            List<ushort> copyImage = new List<ushort>();
            foreach (var item in ListImage)
            {
                if (item > f_SplitData)
                {
                    us_Data = 0xff;
                    n_Hight++;
                }

                else
                {
                    us_Data = 0x00;
                    n_Low++;
                }
                ListbtImage.Add(us_Data);
            }
            string str_temp;
            str_temp = string.Format("n_Hight : [{0}]  n_Low : [{1}]", n_Hight, n_Low);
            //listBox.Items.Add(str_temp);
            //      listBox.Items.Add()
        }

        public void BinRead_float(string readPath, ref List<float> image, ref int lines, ref int width)
        {

            // file 이 없을경우 추가

            float[] bt_Data = null;
            using (FileStream stream = new FileStream(readPath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(stream))
            {
                lines = reader.ReadInt32();
                width = reader.ReadInt32();
                int nSize = lines * width;
                bt_Data = new float[nSize];


                //// 이미지를 10번에 걸쳐 나누어 읽음
                //bt_Data = stream.Read(bt_Data, 0, nSize);
                for (int i = 0; i < nSize; i++)
                {
                    bt_Data[i] = reader.ReadUInt32();

                    if (i > 99999)
                    {
                        float n_1 = bt_Data[i];
                    }
                    //....
                    //Console.WriteLine(n);
                }
                //reader.ReadInt16();
                reader.Close();
            }

            image = bt_Data.ToList();
        }

        private void binFileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strFileName;

            //CogImageFileTool ImageFile = new CogImageFileTool();

            OpenFileDialog OpenFile = new OpenFileDialog();

            OpenFile.DefaultExt = "bin";
            OpenFile.Filter = "Bin Files (*.bin)|*.bin";

            OpenFile.ShowDialog();

            if (OpenFile.FileName.Length > 0)
            {
                strFileName = OpenFile.FileName;

                //Mat src = Cv2.ImRead(strFileName, ImreadModes.AnyColor);

                //Master = Cv2.ImRead("C:\\Users\\vinos\\Desktop\\master.bmp", ImreadModes.AnyColor);

                //Origin = new Mat();
                //Origin = src;

                //Canny = Cv2.ImRead(strFileName, ImreadModes.Grayscale);

                //CannyColor = Cv2.ImRead(strFileName, ImreadModes.Color);

                //ImageFile.Operator.Open(strFileName, CogImageFileModeConstants.Read);
                //ImageFile.Run();

                str_Path_bin = strFileName;

                listBox1.Items.Add("Bin Image Open.");
            }

            //cogDisplay2.Image = ImageFile.OutputImage;

            //pictureBoxIpl1.ImageIpl = Origin;
        }

        private void textDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsposeOcr ocr = new AsposeOcr();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            //pictureBoxIpl1.Image.Save();
            string result = ocr.RecognizeImage(ms);
        }

        private void halconOCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Halcon halcon = new Halcon();
            halcon.GetSearchFileInfo(mBitmap, out searchChar, out searchPosX, out searchPosY);

            listBox1.Items.Clear();

            listBox1.Items.Add("찾은 갯수 : " + searchChar.Count);
            listBox1.Items.Add("======================================================================================");

            for (int n = 0; n < searchChar.Count; n++)
            {
                listBox1.Items.Add("찾은 문자열 : " + searchChar.ElementAt(n));
                listBox1.Items.Add("찾은 문자열 " + searchChar.ElementAt(n) + " 의 X 좌표 : " + searchPosX.ElementAt(n).ToString());
                listBox1.Items.Add("찾은 문자열 " + searchChar.ElementAt(n) + " 의 Y 좌표 : " + searchPosY.ElementAt(n).ToString());

                listBox1.Items.Add("======================================================================================");
            }
        }

        private void imageSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void halconBlobDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Halcon halcon = new Halcon();
            double resultValue = halcon.blobDetection(mBitmap);

            listBox1.Items.Clear();
            double areaValue = mBitmap.Width * mBitmap.Height;
            listBox1.Items.Add("이미지의 크기 : " + string.Format("{0:#,0}", areaValue));            
            listBox1.Items.Add("Blob 영역의 합 : " + string.Format("{0:#,0}", resultValue));

            double rValue = (resultValue / areaValue) * 100;

            listBox1.Items.Add("Blob % : " + string.Format("{0:F2}", rValue));
        }

        private void 이진화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat binImage = new Mat();
            double threshold = Convert.ToDouble(textBox_binThreshold.Text);
            double maxValue = Convert.ToDouble(textBox_bnMaxValue.Text);

            Cv2.Threshold(GrayMaster, binImage, threshold, maxValue, ThresholdTypes.Binary);

            Cv2.ImShow("이진화", binImage);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox_binThreshold.Text = trackBar1.Value.ToString();
        }

        private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int result = 0;
            Cam camera = new Cam();
            camera.Connect();
            MatType type;
            bool isColor = true;

            Feature pixelformat = new Feature();
            if ((camera.f.PixelFormat.GetEnumValueList().TryGetValue("BGR8", out pixelformat)) && pixelformat.IsAvailable)
            {
                camera.f.PixelFormat.ValueString = "BGR8";
                type = MatType.CV_8UC3;
            }
            else if ((camera.f.PixelFormat.GetEnumValueList().TryGetValue("Mono8", out pixelformat))
                    && pixelformat.IsAvailable)
            {
                camera.f.PixelFormat.ValueString = "Mono8";
                type = MatType.CV_8UC1;
                isColor = false;
            }
            else
            {
                type = MatType.CV_8UC1;
                System.Console.Write("no supported pixel format");
                result = 0;
            }
            camera.f.ExposureTime.Value = 10000;

            VideoWriter video = new VideoWriter("outcsharp.avi", VideoWriter.FourCC('X', 'V', 'I', 'D'), 10, new OpenCvSharp.Size(camera.f.Width.Value, camera.f.Height.Value), isColor);
            const string windowName = "Press [Esc] to quit.";
            for (int count = 0; count < 200; ++count)
            {
                using (NeoAPI.Image image = camera.GetImage())
                {
                    var img = new Mat((int)image.Height, (int)image.Width, type,
                                image.ImageData);
                    Cv2.NamedWindow(windowName, WindowMode.Normal);
                    Cv2.ImShow(windowName, img);
                    video.Write(img);
                }
                if (Cv2.WaitKey(1) == 27)
                {
                    break;
                }
            }
            Cv2.DestroyWindow(windowName);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            strings.Clear();

            strings.Add("GRON");
            strings.Add("NE");
            strings.Add("NX");
            strings.Add("LEX");
            strings.Add("GL3");
            strings.Add("GL3");
            strings.Add("IHL");
            strings.Add("YG");
            strings.Add("ZHE");
            strings.Add("GL3");

            stringsContent.Add("ID_1");
            stringsContent.Add("ID_2");
            stringsContent.Add("ID_3");
            stringsContent.Add("ID_4");
            stringsContent.Add("ID_5");
            stringsContent.Add("ID_6");
            stringsContent.Add("ID_7");
            stringsContent.Add("ID_8");
            stringsContent.Add("ID_9");
            stringsContent.Add("ID_10");

            copystrings = strings.ToList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<string> items = strings.FindAll(x => x.Contains("GL3"));

            List<int> index = new List<int>();

            int count = 0;

            int[] searchitem = new int[items.Count];

            for (int i = 0; i < items.Count; i++)
            {
                index.Add(copystrings.FindIndex(x => x.Contains("GL3")));
                copystrings.RemoveAt(index.ElementAt(count));
                copystrings.Insert(index.ElementAt(count), "Test");
                count++;
            }       
            
            for (int n = 0; n < items.Count; n++)
            {
                listBox1.Items.Add(strings[index[n]] + "  " + stringsContent[index[n]]);
            }            
        }

        private void 연결ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = new Mat();
            Cv2.HConcat(new Mat[] { dilate, erode }, dst);
            Cv2.ImShow("연결", dst);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}
