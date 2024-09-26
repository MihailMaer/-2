using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Прак2
{
    internal class Cl
    {
        
       

        public void summa(double num_one, double num_two)
        {
            Console.WriteLine(num_one + num_two);
        }
        public void minuc(double num_one, double num_two)
        {
            Console.WriteLine(num_one - num_two);
        }
        public void multiplications(double num_one, double num_two)
        {
            Console.WriteLine(num_one * num_two);
        }
        public void division(double num_one, double num_two)
        {
            if (num_two == 0)
            {
                Console.WriteLine("На 0 делить нельзя");
            }
            else
            {
                Console.WriteLine(num_one / num_two);
            }

        }
        public void sinmultiplications(double num_one, double num_two)
        {
            Console.WriteLine(Math.Sin(num_one) * num_two);
        }
        public void cosmultiplications(double num_one, double num_two)
        {
            Console.WriteLine(Math.Cos(num_one) * num_two);

        }
        public void sindivision(double num_one, double num_two)
        {
            Console.WriteLine(Math.Sin(num_one) / num_two);

        }
        public void cosdivision(double num_one, double num_two)
        {
            Console.WriteLine(Math.Cos(num_one) / num_two);
        }
        public void arsinmultiolications(double num_one, double num_two)
        {
            Console.WriteLine(Math.Asin(num_one) * num_two);
        }
        public void arcosmultiplications(double num_one, double num_two)
        {
            Console.WriteLine(Math.Log(num_one) * num_two);
        }
        public void PlTR(double num_one, double num_two)
        {
            Console.WriteLine(0.5 * (num_one * num_two));

        }
        public void ScIRCLeD(double num_one, double num_two)
        {
            Console.WriteLine((num_one * num_one) / 4 * 3.14);
        }
        public void ScIRCLeR(double num_one, double num_two)
        {
            Console.WriteLine(3.14 * (num_one * num_one));
        }
        public void SKV(double num_one, double num_two)
        {
            Console.WriteLine(num_one * num_one);
        }
    }
}




  
