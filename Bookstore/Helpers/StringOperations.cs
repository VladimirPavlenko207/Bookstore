using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Helpers
{
    public static class StringOperations
    {
        public static bool AreTheListsTheSame(List<string> list1, List<string> list2)
        {
            if (list1 is null || list2 is null) return false;
            if (list1.Count != list2.Count) return false;

            var l1 = list1.OrderBy(e => e);
            var l2 = list2.OrderBy(e => e);
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i]) return false;
            }
            return true;
        }
    }
}
