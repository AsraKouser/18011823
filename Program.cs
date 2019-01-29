using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace demoapplication
{
        public static class TestClass
        {
        // This method violates the rule.

        [SuppressMessage("Microsoft.Performance", "CA1801:Avoid unused parameters", Justification = "FxBankruptancy")]
        public static string GetSomething(int first, int second)
            {
                return first.ToString(CultureInfo.InvariantCulture);
            }

        // This method satisfies the rule.
        [SuppressMessage("Microsoft.Performance", "CA1806:Do not ignore method calls", Justification = "FxBankruptancy")]
        public static string GetSomethingElse(int first)
        {
            first.ToString().Trim();
            return first.ToString(CultureInfo.InvariantCulture);
        }
        public static void Main()
        {
            GetSomething(01, 05);
                
        }
    }
}
