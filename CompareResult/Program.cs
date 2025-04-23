string s1 = "Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. You can also type a keyword to search online for the video that best fits your document.Reading is easier, too, in the new Reading view. You can collapse parts of the document and focus on the text you want. If you need to stop reading before you reach the end, Word remembers where you left off - even on another device.Save time in Word with new buttons that show up where you need them. To change the way a picture fits in your document, click it and a button for layout options appears next to it. When you work on a table, click where you want to add a row or a column, and then click the plus sign.Themes and styles also help keep your document coordinated. When you click Design and choose a new Theme, the pictures, charts, and SmartArt graphics change to match your new theme. When you apply styles, your headings change to match the new theme.Many string comparison methods (such as String.StartsWith) use linguistic rules for the current culture by default to order their inputs. This is sometimes referred to as \"word sort order.\" When you perform a linguistic comparison, some nonalphanumeric Unicode characters might have special weights assigned. For example, the hyphen";
string s2 = "Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. You can also type a keyword to search online for the video that best fits your document.Reading is easier, too, in the new Reading view. You can collapse parts of the document and focus on the text you want. If you need to stop reading before you reach the end, Word remembers where you left off - even on another device.Save time in Word with new buttons that show up where you need them. To change the way a picture fits in your document, click it and a button for layout options appears next to it. When you work on a table, click where you want to add a row or a column, and then click the plus sign.Themes and styles also help keep your document coordinated. When you click Design and choose a new Theme, the pictures, charts, and SmartArt graphics change to match your new theme. When you apply styles, your headings change to match the new theme.Many string comparison methods (such as String.StartsWith) use linguistic rules for the current culture by default to order their inputs. This is sometimes referred to as \"word sort order.\" When you perform a linguistic comparison, some nonalphanumeric Unicode characters might have special weights assigned. For example, the hyphen";
bool val1 = false, val2 = false;


int loopCounter = 1000000, val3;

CompareResult.CustomStopWatch sw = new CompareResult.CustomStopWatch();
sw.Start();
for (int i = 0; i < loopCounter; i++)
{
    val1 = s1.ToLower() == s2.ToLower();
}
sw.Stop();

CompareResult.CustomStopWatch sw1 = new CompareResult.CustomStopWatch();
sw1.Start();
for (int i = 0; i < loopCounter; i++)
{
    val2 = s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
}
sw1.Stop();

CompareResult.CustomStopWatch sw2 = new CompareResult.CustomStopWatch();
sw2.Start();
for (int i = 0; i < loopCounter; i++)
{
    val3 = String.Compare(s1, s2, StringComparison.OrdinalIgnoreCase);
}
sw2.Stop();

Console.WriteLine($"Result of--> s1.ToLower() == s2.ToLower()->: {sw.ElapsedMilliseconds} Milliseconds, StartAt: {sw.StartAt.Value}, EndAt: {sw.EndAt.Value}");
Console.WriteLine($"Result of--> s1.Equals(s2,StringComparison.OrdinalIgnoreCase)->: {sw1.ElapsedMilliseconds} Milliseconds, StartAt: {sw1.StartAt.Value}, EndAt: {sw1.EndAt.Value}");
Console.WriteLine($"Result of--> String.Compare(s1, s2, StringComparison.OrdinalIgnoreCase)->: {sw2.ElapsedMilliseconds} Milliseconds, StartAt: {sw2.StartAt.Value}, EndAt: {sw2.EndAt.Value}");
Console.ReadKey();

//Compare IEnumerable, IList and ToList
/* const int NumElements = 1000000; // Change this value based on your testing needs

 List<int> originalList = Enumerable.Range(1, NumElements).ToList();

 // Test using IEnumerable
 CompareResult.CompareListData.TestIEnumerable(originalList);

 // Test using IList
 CompareResult.CompareListData.TestIList(originalList);

 // Test using ToList()
 CompareResult.CompareListData.TestToList(originalList);*/

//using CompareResult;
//using System.Diagnostics;

//const int N = 10000000; 


//IList<ReturnCollectionValue> ilistCollection = CompareResult.CollectionCompare.GetIListCollection(N);
//IEnumerable<ReturnCollectionValue> enumerableCollection = CompareResult.CollectionCompare.GetEnumerableCollection(N);
//List<ReturnCollectionValue> listCollection = CompareResult.CollectionCompare.GetListCollection(N);

//Stopwatch stopwatch = new Stopwatch();

//stopwatch.Start();
//foreach (var item in enumerableCollection)
//{

//}
//stopwatch.Stop();
//Console.WriteLine($"IEnumerable iteration time: {stopwatch.ElapsedMilliseconds} ms");

//stopwatch.Reset();
//stopwatch.Start();
//for (int i = 0; i < ilistCollection.Count; i++)
//{
//    var item = ilistCollection[i];
//}
//stopwatch.Stop();
//Console.WriteLine($"IList iteration time: {stopwatch.ElapsedMilliseconds} ms");

//stopwatch.Reset();
//stopwatch.Start();
//foreach (var item in listCollection)
//{

//}
//stopwatch.Stop();
//Console.WriteLine($"List iteration time: {stopwatch.ElapsedMilliseconds} ms");