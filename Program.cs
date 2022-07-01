namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            Frequency frequency = new Frequency();
            string str = "To be or not to be";
            string[] sentenceSplit = frequency.splitString(str);
            frequency.countWords(sentenceSplit);

        }
    }
}