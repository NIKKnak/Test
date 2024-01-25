using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class WorcWithNumbers
    {

        public void WorcNum()
        {

            string str = "asd dsfdfdsf dsfdsf f,d";

            string[] end = str.Split(new char[] { ' ' , ','});
            Console.WriteLine(end.Length);
        }



    }
}
