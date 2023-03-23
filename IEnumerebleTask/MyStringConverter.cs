using System.Collections;

namespace IEnumerableTask;
public class MyStringConverter : IEnumerable<string>
{
    private string[] subs;
    private ClassIEnumerator orderedWords;

    public MyStringConverter(string text)
    {
        subs = text.Trim().Split(' ');
        orderedWords = new ClassIEnumerator(subs);
        orderedWords.GetOrderedWords();
    }

    public IEnumerable<string> GetOrderedWowrds()
    {
        foreach (var word in orderedWords)
            yield return (string)word;
    }

    public IEnumerator<string> GetEnumerator()
    {
        return new MyEnumerator(subs);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}