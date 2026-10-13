using System;
using System.IO;

string[] comments = File.ReadAllLines("std.txt");


 
 File.AppendAllText("std.txt", "This is a new comment." + Environment.NewLine);
 
 foreach (string comment in comments)
{
    Console.WriteLine(comment);
}

Console.WriteLine("Hello, World!");

Console.ReadLine();
