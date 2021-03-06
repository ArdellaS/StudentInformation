﻿using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            bool flag;
            string answer = "";
            string also = "";
            Console.WriteLine($"\t\tWelcome to our student traceker! What would you like to do today?\n\n");
            do
            {
                string[] names = { "Alphaffa", "Benny", "Charlie", "Dennis", "Evan", "Frank", "Gerome", "Henry", "Ines", "Juliet" };
                string[] candy = { "Almond Joy", "Babe Ruth", "Crunch Bar", "DumDum", "Everlasting Gobstopper", "Ferrero Rocher", "Good and Plenty", "Heath Bar", "Ice Breaker Gum", "Jolly Rancher" };
                string[] title = { "Admin", "Bartender", "Cat Rangler", "Dog Walker", "Electric Slider", "Foxtrot Tutor", "Golf Instructor", "Hotel Manager", "Ice Skater", "Jump Force Game Tester" };

                int choice =GetInt("1.) View Student List\n2.) View personal information");

                if (choice == 1)
                {
                    Console.WriteLine("List of available students: ");
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}.) {names[i]}");
                    }
                    Console.WriteLine("");
                    continue;
                }
                if (choice == 2)
                {
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
                    

                    while (detail.Equals("favorite candy") || detail.Equals("favorite") || detail.Equals("candy"))
                    {
                        Console.WriteLine($"{names[index - 1]}'s favorite candy is {candy[index - 1]}.");
                        also = GetString($"\nWould you also like to know {names[index - 1]}'s previous job title? Yes/No").ToLower();
                        if (also.Equals("yes"))
                        {
                            Console.WriteLine($"\n{names[index - 1]}'s previous title was {title[index - 1]}.");
                            
                        }
                        else
                        {
                            detail = "out";
                        }
                    }
                     
                    while(detail.Equals("previous title") || detail.Equals("title") || detail.Equals("previous"))
                    {
                        Console.WriteLine($"\n{names[index - 1]}'s previous title was {title[index - 1]}.");
                        also = GetString($"Would you also like to know {names[index - 1]}'s favorite candy?").ToLower();
                        if (also.Equals("yes"))
                        {
                            Console.WriteLine($"\n{names[index - 1]}'s favorite candy is {candy[index - 1]}.");
                        }
                        else
                        {
                            detail = "out";
                        }
                    }
                    if(!detail.Equals("out"))
                    {
                        
                        continue;
                    }
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
