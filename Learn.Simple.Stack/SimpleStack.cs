using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class SimpleStack
    {
        public static void SampleStack()
        {
            //Creates and initializes a new Stack.
            Stack myStack = new();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            //Displays the properties and values of the Stack.
            Console.WriteLine("myStack");
            Console.WriteLine($"\tCount:\t{myStack.Count}");
            Console.Write("\tValues:");
            PrintValues(myStack);
        }

    private static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
        {
            Console.Write($"\t{obj}");
        }
        Console.WriteLine();
    }
}

/*
This code produces the following output.
myStack
    Count:    3
    Values:    !    World    Hello
*/
