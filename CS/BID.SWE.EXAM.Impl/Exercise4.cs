using System;
using System.IO;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            string s = $" Frohe Weinachten ";
            int i = 42;
            bool b = false;

            StringBuilder sb = new StringBuilder();
            sb.Append(s + "\n");
            sb.Append(i.ToString() + "\n");
            if (!b)
            {
                sb.Append("false \n");
            }
            

            //Textreader reader = new StringReader;
            
            throw new NotImplementedException();
        }

        public object Method2(object obj)
        {
            
            
            throw new NotImplementedException();
        }
    }
}