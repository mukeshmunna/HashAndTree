using HashAndTree.HashAndTree;
using HashAndTree;
using HashAndTrees;

internal class Program
{
    private static void Main(string[] args)
    {
        /* string statement = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
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
         Console.WriteLine("Enter the word to be Removed");
         string word = Console.ReadLine();
             int count = 0;
             for (int i = 0; i < sentence.Length; i++)
             {
                 if (hash.Get(Convert.ToString(i)) == word)
                 {
                     hash.Remove(Convert.ToString(i));
                     count++;
                 }
             }
             if (count == 0)
                 Console.WriteLine("Enter the correct word to Remove");*/

        BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
        binarySearch.Insert(30);
        binarySearch.Insert(70);
        binarySearch.Insert(22);
        binarySearch.Insert(40);
        binarySearch.Insert(60);
        binarySearch.Insert(95);
        binarySearch.Insert(11);
        binarySearch.Insert(65);
        binarySearch.Insert(3);
        binarySearch.Insert(16);
        binarySearch.Insert(63);
        binarySearch.Insert(67);
        binarySearch.Display();
        binarySearch.GetSize();

    }
    
}