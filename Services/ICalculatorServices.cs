using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorAPI.Models;

namespace CalculatorAPI.Services
{
    public interface ICalculatorServices
    {
        CalculatorItems SumCalculatorItems(CalculatorItems items);

        CalculatorItems MultiplyCalculatorItems(CalculatorItems items);

        CalculatorItems DivideCalculatorItems(CalculatorItems items);

        CalculatorItems PowerCalculatorItems(CalculatorItems items);

        CalculatorItems SquareRootCalculatorItems(CalculatorItems items);
    }
}
