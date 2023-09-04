namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstelle ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
            //Schreibe dann einen Bubblesort um die Zahlen aufsteigend, von der kleinsten bis zur größten Zahl, zu sortieren.
            //Lass dir zur Kontrolle dann das sortierte Array in der Konsole ausgeben.

            int[] array = { 4, 33, 7, 1, 23, 12 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"Die Zahlen, aufsteigend, sind:");
            foreach (int bubblesort in array)
            {
                Console.WriteLine(bubblesort);
            }
        }
    }
}