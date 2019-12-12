using System;
using System.Collections.Generic;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class CellPrinter : ICellPrinter
    {
        public string PrintState(bool alive, DateTime date, string color)
        {
            string s;
            
            if (alive)
            {
                //Console.WriteLine("Cell " + color + "born on " + date.ToString() + "is alive.");
                s = $"Cell {color} born on {date.ToString()} is alive.";
            }
            else
            {
                //Console.WriteLine("Cell " + color + "born on " + date + "is dead.");
                s = $"Cell {color} born on {date.ToString()} is dead.";
            }
            return s;
        }

        public string PrintPostion(int x, int y)
        {
            //Console.WriteLine("Cell is on Position X:" + x + "Y:" + y);
            string s = $"Cell is on Position X:{x} Y:{y}";

            return s;
        }
    }
}
