using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Polymorphism_4530
{
    internal class Epson : PrinterWindows
        {
            public override void Show()
            {

                Console.WriteLine("\nEpson display dimension : 10*11");
            }
            public override void Print()
            {
                Console.WriteLine("Epson printer printing....");
            }
        }
    }
