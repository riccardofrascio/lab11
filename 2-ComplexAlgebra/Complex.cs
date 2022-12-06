using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        // TODO: fill this class\
        public double Real { get; }

        public double Imaginary { get; }

        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public double Modulus => Math.Sqrt(Real * Real + Imaginary * Imaginary);

        public double Phase => Math.Atan2(Imaginary, Real);

        public override string ToString()
        {
            if (Imaginary == 0.0) return Real.ToString();
            var imAbs = Math.Abs(Imaginary);
            var imValue = imAbs == 1.0 ? "" : imAbs.ToString();
            string sign;
            if (Real == 0d)
            {
                sign = Imaginary > 0 ? "" : "-";
                return sign + "i" + imValue;
            }

            sign = Imaginary > 0 ? "+" : "-";
            return $"{Real} {sign} i{imValue}";
        }
        public bool Equals(Complex obj)
        {
            return this.Real.Equals(obj.Real) && this.Imaginary.Equals(obj.Imaginary);
        }

        public Complex Complement() => new Complex(Real, -Imaginary);

        public Complex Plus(Complex other) =>
            new Complex(this.Real + other.Real, this.Imaginary+other.Imaginary);
        
        public Complex Minus(Complex other) =>
            new Complex(this.Real - other.Real, this.Imaginary - other.Imaginary);
    }
}