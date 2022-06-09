using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Polymorphism_4530
{
    internal class PrinterWindows
    {
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Pilih printer :");
        }
        public virtual void Print()
        {
            Console.WriteLine("Pilih printer :");

        }
    }
}

