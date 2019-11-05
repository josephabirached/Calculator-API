using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorAPI.Models;

namespace CalculatorAPI.Services
{
    public class CalculatorServices : ICalculatorServices
    {
        
        
        public CalculatorItems SumCalculatorItems(CalculatorItems items)
        {
            var sum = items.Num1 + items.Num2;
            items.Reslt = sum;


            return items;
        }

        public CalculatorItems MultiplyCalculatorItems(CalculatorItems items)
        {
            var mult = items.Num1 * items.Num2;
            items.Reslt = mult;

            return items;
        }

        public CalculatorItems DivideCalculatorItems(CalculatorItems items)
        {
            var div = items.Num1 / items.Num2;
            items.Reslt = div;


            return items;
        }

        public CalculatorItems PowerCalculatorItems(CalculatorItems items)
        {
            var pw = Math.Pow(items.Num1,items.Num2);
            items.Reslt = pw;


            return items;
        }

        public CalculatorItems SquareRootCalculatorItems(CalculatorItems items)
        {
            var sq = Math.Sqrt(items.Num1);
            items.Reslt = sq;

            return items;
        }
    }
}
