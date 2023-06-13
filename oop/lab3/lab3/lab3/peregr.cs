using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public partial class ARR
    {
        public static ARR operator *(ARR a, ARR b)
        {
            if (a.length != b.length)
            {
                Console.WriteLine("Умножение не возможно, тк разный размер массивов");
                throw new InvalidOperationException();
            }
            var res = new ARR(a.length);

            for (int i = 0; i < a.length; i++)
            {
                res[i] = a[i] * b[i];
            }
            return res;
        }

        public static bool operator !=(ARR a, ARR b)
        {
            if (a.length != b.length)
            {
                Console.WriteLine("Сравнение не возможно, тк разный размер массивов");
                return false;
            }

            for (int i = 0; i < a.length; i++)
            {
                if (a[i] != b[i])
                    return true;
            }
            return false;
        }

        public static bool operator ==(ARR a, ARR b)
        {
            if (a.length != b.length)
            {
                Console.WriteLine("Сравнение не возможно, тк разный размер массивов");
                return false;
            }

            for (int i = 0; i < a.length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
        public static bool operator >(ARR a, ARR b)
        {
            if (a.length != b.length)
            {
                Console.WriteLine("Сравнение не возможно, тк разный размер массивов");
                return false;
            }
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < a.length; i++)
            {
                sum1 += a[i];
                sum2 += b[i];
            }
            return sum1 > sum2;
        }

        public static bool operator <(ARR a, ARR b)
        {
            if (a.length != b.length)
            {
                Console.WriteLine("Сравнение не возможно, тк разный размер массивов");
                return false;
            }
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < a.length; i++)
            {
                sum1 += a[i];
                sum2 += b[i];
            }
            return sum1 < sum2;
        }
        public static bool operator true(ARR a)
        {
            for (int i = 0; i < a.length; i++)
            {
                if (a[i] < 0)
                    return false;
            }
            return true;
        }
        public static bool operator false(ARR a)
        {
            for (int i = 0; i < a.length; i++)
            {
                if (a[i] > 0)
                    return false;
            }
            return true;
        }

        public static explicit operator int(ARR a)
        {
            int res=a.length;
            return res;
        }
    }
}
