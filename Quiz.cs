using System;
public class Quiz
{
 public static void Main(string [] args)
 {
    int count=0;
    Console.WriteLine("enter your name:");
    string name=Console.ReadLine();
    Console.WriteLine($"Hello {name}, Welcome to Santa Quiz \n");
    Console.WriteLine("What is the capital of France? ");
    string france=Console.ReadLine();
    string lower1=france.ToLower();
    if(lower1=="paris")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine("Which planet is known as the Red Planet?");
    string planet=Console.ReadLine();
    string lower2=planet.ToLower();
    if(lower2=="mars")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine( "Who is known as the Father of the Nation in India?");
    string wrote=Console.ReadLine();
    string lower3=wrote.ToLower();
    if(lower3=="mahatma gandhi")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine("What is the largest ocean on Earth?");
    string ocean=Console.ReadLine();
    string lower4=ocean.ToLower();
    if(lower4=="pacific ocean")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine("who is the Deputy CM of ap");
    string CM=Console.ReadLine();
    string lower5=CM.ToLower();
    if(lower5=="pawan kalyan")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine($"santa Quiz is completed \n Congratulations you answered {count} questions correctly.So,You earned {count} gift(s) from santa");
 }
}

