﻿using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise1 : IExercise1
    {
        public object Method1()
        {
            CellPrinter cp = new CellPrinter();
            return cp;

            throw new NotImplementedException();
        }
    }
}
