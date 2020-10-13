using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Fatorial
{
    class Fatorial
    {
        public int CalculateFatorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            
            return CalculateFatorial(num - 1) * num;
        }
    }
}
