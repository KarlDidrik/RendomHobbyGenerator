using System.Xml.Linq;

namespace RendomHobbyGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var randomNumber = rand.Next(0, 5);

            Console.WriteLine("Hvem vil ha en ny hobby?");
            string text = Console.ReadLine();
            TextGenerator(text);

            void TextGenerator(string name)
            {
                string returnText;
                if (randomNumber == 0)
                {
                    Console.WriteLine($"{name} is suddenly very interested in a lobotomy");
                }
                else if (randomNumber == 1)
                {
                    Console.WriteLine($"{name} has became the queen of twerkism");
                }
                else if (randomNumber == 2)
                {
                    Console.WriteLine($"{name} gets to have an abortion at clair's");
                }
                else if (randomNumber == 3)
                {
                    Console.WriteLine($"{name} is getting a footjob at denny's");
                }
                else if (randomNumber == 4)
                {
                    Console.WriteLine($"{name} is fancy like dennys on a date night");
                }


            }
        }
    }
}