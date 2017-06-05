using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMath
{
    public class Equation
    {
        private double a = 0;
        private double b = 0;
        private double c = 0;
        private double x = 0;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public double X
        {
            get { return (-1 * b + c) / a; }
        }

        /// <summary>
        /// Ax + B = C;
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        public Equation(double A, double B, double C)
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }
    }
}
