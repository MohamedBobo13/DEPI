using System.Collections;

namespace CollectionFromScratch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyOwnCollection<int> owncollection = new MyOwnCollection<int>();
            owncollection.Add(1);
            owncollection.Add(2);
            owncollection.Add(3);
            owncollection.Add(78);

            // Same Foreach
            IEnumerator iterator = owncollection.GetEnumerator();
            while (iterator.MoveNext())
            {
                int value = (int)iterator.Current;
                Console.WriteLine(value);
            }
            iterator.Reset();

            // Using Foreach
            foreach (var item in owncollection)
            {
                Console.WriteLine(item);
            }

        }
    }
}
