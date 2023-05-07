using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello Chigbu Bryan,");
        Console.WriteLine("I would like to ask you some questions");

        Console.WriteLine("");
            Console.Write("what is your First Name? ");
            string frist_name = Console.ReadLine();

        Console.WriteLine("");
            Console.Write("what is your Second Name? ");
        string second_name = Console.ReadLine();

        Console.WriteLine($"Your name is {frist_name}, {second_name} {frist_name}.");

    }
}