using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Informacijos_saugumas_praktinis_3
{
    class HelperMethods
    {
        // Checks if number is prime
        static public bool checkPrime(BigInteger n)
        {
            if (n <= 3 && n > 1)
            {
                return true;
            }
            else if (n == 1 || n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            else
            {
                for (BigInteger i = 5; i * i <= n; i += 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        // Checks if number is co prime
        static public bool checkCoPrime(BigInteger e, BigInteger phi)
        {
            BigInteger temp;
            while (phi != 0)
            {
                temp = e;
                e = phi;
                phi = temp % phi;
            }
            if (e == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool TryModInverse(BigInteger number, BigInteger modulo, out BigInteger result)
        {
            if (number < 1) throw new ArgumentOutOfRangeException(nameof(number));
            if (modulo < 2) throw new ArgumentOutOfRangeException(nameof(modulo));
            BigInteger n = number;
            BigInteger m = modulo, v = 0, d = 1;
            while (n > 0)
            {
                BigInteger t = m / n, x = n;
                n = m % x;
                m = x;
                x = d;
                d = checked(v - t * x); // Just in case
                v = x;
            }
            result = v % modulo;
            if (result < 0) result += modulo;
            if ((long)number * result % modulo == 1L) return true;
            result = default;
            return false;
        }

    }
}
