using System.Collections;

namespace IEnumerableTask
{
    public class ClassIEnumerator : IEnumerable
    {
        string[] subs;

        public ClassIEnumerator(string[] s)
        {
            subs = s;
        }

        public void GetOrderedWords()
        {
            for (int i = 0; i < subs.Length; i++)
            {
                for (int j = i + 1; j < subs.Length; j++)
                {
                    if (subs[i].Length > subs[j].Length)
                        (subs[i], subs[j]) = (subs[j], subs[i]);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var sub in subs)
            {
                yield return sub;
            }
        }
    }
}