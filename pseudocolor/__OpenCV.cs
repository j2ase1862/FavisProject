using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Blob;


namespace pseudocolor
{
    class __OpenCV : IDisposable
    {  
        public Mat ReadImage(string filePath)
        {
            Mat retVal = Cv2.ImRead(filePath, ImreadModes.AnyColor);            
            return retVal; 
        }

        public void dialte(Mat src, int changeValue, int KernnelValue)
        {
            Mat dst = new Mat();

            Mat element = Cv2.GetStructuringElement(MorphShapes.Ellipse, new OpenCvSharp.Size(changeValue, KernnelValue));
            Cv2.MorphologyEx(src, dst, MorphTypes.Dilate, element, iterations: KernnelValue);

            Cv2.ImShow("Close", dst);

            Cv2.WaitKey(0);

            Cv2.DestroyAllWindows();
        }

        public void Dispose()
        {

        }
    }
}
