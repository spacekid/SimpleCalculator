using System;
using System.ComponentModel.Composition;

namespace SimpleCalculator
{
    [Export(typeof(ICalculator))]
    class MySimpleCalculator : ICalculator
    {
        public string Calculate(string input)
        {
            throw new NotImplementedException();
        }
    }
}
