using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple.PolyMorphism
{
   public class MathUitility
    {
        public int Add(int V1,int V2)
        {
            return (V1 + V2);
        }
        public int Add(int V1, int V2,int V3)
        {
            return (V1 + V2 + V3);
        }

        public int Add(params int[] Values)
        {
            int Sum = 0;

            foreach (int n in Values)
            {
                Sum += n;
            }

            return Sum;
        }

        public float Add(int V1,float V2)
        {
            return (V1 + V2);
        }

        public float Add(float V1, int V2)
        {
            return (V1 + V2);
        }

        public float Add(float V1, int V2,float V3,int V4)
        {
            return (V1 + V2);
        }
    }
}
