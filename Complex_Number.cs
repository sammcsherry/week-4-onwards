using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFT_week_4
{
  
    public class Complex_Number
    {
        public double real;
        public double imaginary;

        public Complex_Number(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex_Number operator +(Complex_Number complex_1, Complex_Number complex_2)
        {
            return new Complex_Number(complex_1.real + complex_2.real, complex_1.imaginary + complex_2.imaginary);
        }

        public static Complex_Number operator *(Complex_Number complex_1, Complex_Number complex_2)
        {
            return new Complex_Number(complex_1.real*complex_2.real - complex_1.imaginary * complex_2.imaginary
                                      ,complex_1.real*complex_2.imaginary + complex_1.imaginary * complex_2.real);
        }
        public static Complex_Number operator *(double real, Complex_Number complex_2)
        {
            Complex_Number complex_1 = new Complex_Number(real, 0);
            return new Complex_Number(complex_1.real * complex_2.real
                                      ,complex_1.real * complex_2.imaginary);
        }

        public static Complex_Number operator *(Complex_Number complex_2, double real)
        {
            Complex_Number complex_1 = new Complex_Number(real, 0);
            return new Complex_Number(complex_1.real * complex_2.real
                                      , complex_1.real * complex_2.imaginary);
        }

    }
}
