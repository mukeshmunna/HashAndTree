using HashAndTree.HashAndTree;
using HashAndTree;

internal class Program
{
    private static void Main(string[] args)
    {
        string statement = "To be or Not To be";
        string[] sentence = statement.Split(" ");
        MapNode<string, string> hash = new MapNode<string, string>(sentence.Length);
        for (int i = 0; i < sentence.Length; i++)
        {
            hash.Add(Convert.ToString(i), sentence[i]);
        }
        for (int i = 0; i < sentence.Length; i++)
        {
            int Count = 1;
            for (int j = i + 1; j < sentence.Length; j++)
            {
                if (hash.Get(Convert.ToString(i)) == hash.Get(Convert.ToString(j)))
                {
                    Count++;
                    sentence[j] = null;
                }
            }
            if (sentence[i] != null)
                Console.WriteLine("The Frequency of the Word " + sentence[i] + " is " + Count);
        }
    }
}