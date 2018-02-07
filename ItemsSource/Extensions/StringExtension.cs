using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsSource.Extensions
{
    public static class StringExtension
    {
        public static string MyExt(this string test, int asd)
        {
            return test.ToLower().Substring(0, asd);
        }
    }
}
