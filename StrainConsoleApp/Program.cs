using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrainConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var keepReturn = Strain.Keep(new HashSet<int> { 1, 2, 3, 4, 5, 11, 12, 8 }, (x => x < 10));
            foreach (var x in keepReturn)
            {
                global::System.Console.WriteLine(x);
            }
            Console.ReadKey();

        }                
    }

    public static class Strain
    {

        public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var returnList = new List<T>();

            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    returnList.Add(item);
                }
            }

            return returnList;
        }

        public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var returnList = new List<T>();

            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    returnList.Add(item);
                }
            }

            return returnList;
        }
    }
}
