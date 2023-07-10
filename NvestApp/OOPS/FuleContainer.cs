using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.OOPS
{
    class FuleContainer
    {
        public int Length;
        public int Width;
        public int Height;
        public FuleContainer()
        {
            Length = 1;
            Width = 1;
            Height = 1;
        }

        public FuleContainer(int H, int W, int L)
        {
            Length = L;
            Width = W;
            Height = H;
        }

        public FuleContainer(FuleContainer container)
        {
            Length = container.Length;
            Width = container.Width;
            Height = container.Height;
        }
        public int GetArea()
        {
            int Area = Length * Width * Height;
            return Area;
        }
    }
}
