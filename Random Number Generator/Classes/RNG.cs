using System;

namespace RandomNumberGenerator.Classes
{
    internal class Rng
    {
        private static uint _mW;
        private static uint _mZ;

        static Rng()
        {
            // Set Seed values used by "Marsaglia". Any pair of unsigned integers can be used.
            _mW = 521288629;
            _mZ = 362436069;
        }

        #region "Set Seed"

        public static void SetSeed(uint u, uint v)
        {
            if (u != 0) _mW = u;
            if (v != 0) _mZ = v;
        }

        public static void SetSeed(uint u)
        {
            _mW = u;
        }

        public static void SetSeedFromSystemTime()
        {
            var dt = DateTime.Now;
            var x = dt.ToFileTime();
            SetSeed((uint)(x >> 16), (uint)(x % 4294967296));
        }

        #endregion

        /// <summary>
        /// Produces an unsigned integer using George Marsaglia's MWC algorithm.
        /// </summary>
        /// <returns>Unsigned Integer in the range [0, 2^32)</returns>
        private static uint GetUint()
        {
            _mZ = 36969 * (_mZ & 65535) + (_mZ >> 16);
            _mW = 18000 * (_mW & 65535) + (_mW >> 16);
            return (_mZ << 16) + _mW;
        }

        // Produce a uniform random sample from the open interval (0, 1).
        // The method will not return either end point.
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static double GetUniform()
        {
            var u = GetUint();
            // The magic number below is 1/(2^32 + 2).
            // The result is strictly between 0 and 1.
            return (u + 1.0) * 2.328306435454494e-10;
        }

        /// <summary>
        /// Get Normal (Gaussian) distributed random number.
        /// </summary>
        /// <param name="mean">Mean</param>
        /// <param name="standardDeviation">Standard Deviation</param>
        /// <returns></returns>
        public static double GetNormal(double mean = 0, double standardDeviation = 1)
        {
            if (standardDeviation <= 0.0)
            {
                var msg = $"Shape must be positive. Received {standardDeviation}.";
                throw new ArgumentOutOfRangeException(msg);
            }

            var u1 = GetUniform();
            var u2 = GetUniform();
            var r = Math.Sqrt(-2.0*Math.Log(u1));
            var theta = 2.0*Math.PI*u2;
            var m0Std1 = r*Math.Sin(theta);
            return mean + standardDeviation*m0Std1;
        }

        /// <summary>
        /// Get Exponentially distributed random number.
        /// </summary>
        /// <param name="mean">Mean</param>
        /// <returns></returns>
        public static double GetExponential(double mean = 1)
        {
            if (mean <= 0.0)
            {
                var msg = $"Mean must be positive. Received {mean}.";
                throw new ArgumentOutOfRangeException(msg);
            }

            return mean * (-Math.Log(GetUniform()));
        }

        public static double GetGamma(double shape, double scale)
        {
            // Implementation based on "A Simple Method for Generating Gamma Variables"
            // by George Marsaglia and Wai Wan Tsang.  ACM Transactions on Mathematical Software
            // Vol 26, No 3, September 2000, pages 363-372.

            if (shape >= 1.0)
            {
                var d = shape - 1.0 / 3.0;
                var c = 1.0 / Math.Sqrt(9.0 * d);
                for (;;)
                {
                    double x;
                    double v;
                    do
                    {
                        x = GetNormal();
                        v = 1.0 + c * x;
                    }
                    while (v <= 0.0);
                    v = v * v * v;
                    var u = GetUniform();
                    var xsquared = x * x;
                    if (u < 1.0 - .0331 * xsquared * xsquared || Math.Log(u) < 0.5 * xsquared + d * (1.0 - v + Math.Log(v)))
                        return scale * d * v;
                }
            }
            else if (shape <= 0.0)
            {
                var msg = $"Shape must be positive. Received {shape}.";
                throw new ArgumentOutOfRangeException(msg);
            }
            else
            {
                var g = GetGamma(shape + 1.0, 1.0);
                var w = GetUniform();
                return scale * g * Math.Pow(w, 1.0 / shape);
            }
        }

        public static double GetChiSquare(double degreesOfFreedom)
        {
            // A chi squared distribution with n degrees of freedom
            // is a gamma distribution with shape n/2 and scale 2.
            return GetGamma(0.5 * degreesOfFreedom, 2.0);
        }

        public static double GetInverseGamma(double shape, double scale)
        {
            // If X is gamma(shape, scale) then
            // 1/Y is inverse gamma(shape, 1/scale)
            return 1.0 / GetGamma(shape, 1.0 / scale);
        }

        public static double GetWeibull(double shape, double scale)
        {
            if (shape <= 0.0 || scale <= 0.0)
            {
                var msg = $"Shape and scale parameters must be positive. Recieved shape {shape} and scale{scale}.";
                throw new ArgumentOutOfRangeException(msg);
            }
            return scale * Math.Pow(-Math.Log(GetUniform()), 1.0 / shape);
        }

        public static double GetCauchy(double median, double scale)
        {
            if (scale <= 0)
            {
                var msg = $"Scale must be positive. Received {scale}.";
                throw new ArgumentException(msg);
            }

            var p = GetUniform();

            // Apply inverse of the Cauchy distribution function to a uniform
            return median + scale * Math.Tan(Math.PI * (p - 0.5));
        }

        public static double GetStudentT(double degreesOfFreedom)
        {
            if (degreesOfFreedom <= 0)
            {
                var msg = $"Degrees of freedom must be positive. Received {degreesOfFreedom}.";
                throw new ArgumentException(msg);
            }

            // See Seminumerical Algorithms by Knuth
            var y1 = GetNormal();
            var y2 = GetChiSquare(degreesOfFreedom);
            return y1 / Math.Sqrt(y2 / degreesOfFreedom);
        }

        public static double GetLaplace(double mean, double scale)
        {
            var u = GetUniform();
            return (u < 0.5) ?
                mean + scale * Math.Log(2.0 * u) :
                mean - scale * Math.Log(2 * (1 - u));
        }

        public static double GetLogNormal(double mu, double sigma)
        {
            return Math.Exp(GetNormal(mu, sigma));
        }

        public static double GetBeta(double a, double b)
        {
            if (a <= 0.0 || b <= 0.0)
            {
                var msg = $"Beta parameters must be positive. Received {a} and {b}.";
                throw new ArgumentOutOfRangeException(msg);
            }

            // There are more efficient methods for generating beta samples.
            // However such methods are a little more efficient and much more complicated.
            // For an explanation of why the following method works, see
            // http://www.johndcook.com/distribution_chart.html#gamma_beta

            var u = GetGamma(a, 1.0);
            var v = GetGamma(b, 1.0);
            return u / (u + v);
        }
    }
}
