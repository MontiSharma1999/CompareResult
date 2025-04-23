using System.Diagnostics;

namespace CompareResult
{
    public class CompareListData
    {
        public static void TestIEnumerable(IEnumerable<int> collection)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            foreach (var item in collection)
            {
                var res = item * 2;
            }

            stopwatch.Stop();
            Console.WriteLine($"IEnumerable took: {stopwatch.ElapsedMilliseconds} ms");
        }

        public static void TestIList(IList<int> collection)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < collection.Count; i++)
            {
                var item = collection[i];
                item *= 2;
            }

            stopwatch.Stop();
            Console.WriteLine($"IList took: {stopwatch.ElapsedMilliseconds} ms");
        }

        public static void TestToList(List<int> collection)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            List<int> newList = collection.ToList();

            foreach (var item in newList)
            {
                var res = item * 2;
            }

            stopwatch.Stop();
            Console.WriteLine($"ToList took: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
