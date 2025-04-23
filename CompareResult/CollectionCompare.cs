namespace CompareResult
{
    public class CollectionCompare
    {
        public static IEnumerable<ReturnCollectionValue> GetEnumerableCollection(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return new ReturnCollectionValue { ReturnValue = i.ToString() };
            }
        }

        public static IList<ReturnCollectionValue> GetIListCollection(int n)
        {
            List<ReturnCollectionValue> list = new List<ReturnCollectionValue>();
            for (int i = 0; i < n; i++)
            {
                list.Add(new ReturnCollectionValue { ReturnValue = i.ToString() });
            }
            return list;
        }

        public static List<ReturnCollectionValue> GetListCollection(int n)
        {
            List<ReturnCollectionValue> list = new List<ReturnCollectionValue>();
            for (int i = 0; i < n; i++)
            {
                list.Add(new ReturnCollectionValue { ReturnValue = i.ToString()});
            }
            return list;
        }
    }
    public class ReturnCollectionValue
    {
        public string ReturnValue { get; set; }
    }
}
