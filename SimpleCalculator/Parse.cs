using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parse
    {
        public string Input { get; set; }

       
        public string FirstTerm(string input)
        {
            int positionOfPositiveSymbol = input.IndexOf("+");
            String firstNumber = input.Substring(0, positionOfPositiveSymbol);
            return firstNumber;
        }

        public string SecondTerm(string input)
        {
            int positionOfPositiveSymbol = input.IndexOf("+");
            String secondNumber = input.Substring(positionOfPositiveSymbol+1, 2);
            return secondNumber;
        }

        public string Symbol(string input)
        {
            int positionOfPositiveSymbol = input.IndexOf("+");
            string symbol = input.Substring(positionOfPositiveSymbol, 1);
            return symbol;
        }
    }

    
}
