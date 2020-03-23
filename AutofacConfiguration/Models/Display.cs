using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacConfiguration.Models
{
    public class Display : IDisplay
    {
        public void ShowNumber(string bigNumber)
        {
            Console.WriteLine(bigNumber);
        }
    }
}
