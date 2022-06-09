using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Polymorphism_4530
{
    internal class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nCanon display dimension : 9.5*11");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
}

