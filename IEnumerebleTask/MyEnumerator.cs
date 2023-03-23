using System.Collections;

namespace IEnumerableTask
{
    public class MyEnumerator : IEnumerator<string>
    {
        private string[] subs;
        private int pos = -1;
        public MyEnumerator(string[] s) 
        {
            subs = s;
        }

        public string Current => subs[pos];

        object IEnumerator.Current => throw new NotImplementedException();
        
        public void Dispose() { }

        public bool MoveNext()
        {
            pos++;
            return pos < subs.Length;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}