using HashAndTree.HashAndTree;
using HashAndTree;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HashTable and Binary tree!");
        MapNode<string, string> hash = new MapNode<string, string>(5);
        hash.Add("100", "hundred");
        hash.Add("90", "ninty");
        hash.Add("80", "eighty");
        hash.Add("70", "seventy");
        hash.Add("60", "sixty");
        hash.Add("50", "fifty");
        string hash5 = hash.Get("5");
        Console.WriteLine("5th index value : " + hash5);
        hash.Remove("2");
        string hash2 = hash.Get("2");
        Console.WriteLine("2th index value : " + hash2);




    }
}