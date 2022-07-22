using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace pseudocolor
{
    class ClassFindContour : IDisposable
    {
        Mat bin;
        Mat con;

        public void Dispose()
        {
            //if (bin == null) bin.d
            throw new NotImplementedException();
        }
    }
}
