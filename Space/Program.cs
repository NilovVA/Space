using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Space
{
    public static void Main()
    {
        string aString = "Just like William Shakespeare on literature, and Sigmund Freud on psychology, Picasso's impact on art is tremendous.";
        IEnumerable<char> stringQuery2 = aString.Where(e => e == ' ');

        Console.Write(stringQuery2.Count());

        Console.WriteLine(System.Environment.NewLine + "Press any key to exit");
        Console.ReadLine();
    }
}
