using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            bool flag;
            string answer = "";

            do
            {
                string[] names = { "Alphaffa", "Benny", "Charlie", "Dennis", "Evan", "Frank", "Gerome", "Henry", "Ines", "Juliet" };
                string[] candy = { "Almond Joy", "Babe Ruth", "Crunch Bar", "DumDum", "Everlasting Gobstopper", "Ferrero Rocher", "Good and Plenty", "Heath Bar", "Ice Breaker Gum", "Jolly Rancher" };
                string[] title = { "Admin", "Bartender", "Cat Rangler", "Dog Walker", "Electric Slider", "Foxtrot Tutor", "Golf Instructor", "Hotel Manager", "Ice Skater", "Jump Force Game Tester" };

                Console.WriteLine("List of available students: ");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.) {names[i]}");
                }

                index = GetInt("Input the number of which student you would like to learn more about?\n");
                flag = (index < 11);

                while (!flag)
                {

                    Console.WriteLine("Please enter valid number.");
                    index = GetInt("Input the number of which student you would like to learn more about?\n");
                    flag = (index < 11);
                }
                Console.Clear();
                string detail = GetString($"Student {index} is {names[index - 1]}. What would you like to know about {names[index - 1]}? (enter \"favorite candy\" or \"previous title\"\n").ToLower();

                if (detail.Equals("favorite candy") || detail.Equals("favorite") || detail.Equals("candy"))
                {
                    Console.WriteLine($"{names[index - 1]}'s favorite candy is {candy[index - 1]}.");
                }
                else if (detail.Equals("previous title") || detail.Equals("title") || detail.Equals("previous"))
                {
                    Console.WriteLine($"\n{names[index - 1]}'s previous title was {title[index - 1]}.");
                }
                else
                {
                    detail = GetString($"Please enter \"favorite candy\" or \"previous title\"\n");
                    continue;
                }



                answer = GetString($"\nWould you like to try another student? yes/no");
                Console.Clear();
            } while (!answer.Equals("no"));


        }

        static int GetInt(string prompt)
        {

            Console.WriteLine(prompt);

            return int.Parse(Console.ReadLine());

        }
        static string GetString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

    }
}
