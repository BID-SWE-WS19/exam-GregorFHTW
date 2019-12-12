using System;
using System.Collections.Generic;
using System.Text;
using BID.SWE1.Exam.Interfaces;


namespace BID.SWE.EXAM.Impl
{
    public class implCell : Cell
    {
        //_size protected int only visible for class

        public bool IsALive()
        {
            return true;
        }
        
        public int Grow()
        {
            _size += 1;
            return -_size;
        }
    }
}
