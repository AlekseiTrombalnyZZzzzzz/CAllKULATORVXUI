using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kalkulator_ebaniy
{
    internal class Calculate
    {
        private string symbol;
        private bool isFirstNum = true;
        public void GetNum(string sym)
        {
            this.symbol = sym;
            isFirstNum = false;
        }
        public bool Iscurnum()
        {
            return isFirstNum;
        }
        //public double Getansw(Number num1, Number num2)
        //{
            
        //}
    }
}
