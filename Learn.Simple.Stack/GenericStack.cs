using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class GenericStack
    {
    public static void Generic()
    {
        Stack<string> numbers = new();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        //A stack can be enumerated without disturbing its contents.
        foreach(string number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"\nPopping {numbers.Pop()}");
        Console.WriteLine($"Peek at next item to destack: {numbers.Peek()}");
        Console.WriteLine($"Popping {numbers.Pop()}");

        //Create a copy of the stack, using the ToArray method and the constructor that accepts an IEnumerable<T>.
        Stack<string> stack2 = new(numbers.ToArray());
        Console.WriteLine("\nContents of the first copy: ");
        foreach (string number in stack2)
        {
            Console.WriteLine(number);
        }

        //Create an array twice the size of the stack and copy the elements of the stack, starting at the middle of the array
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);

        //Create a second stack, using the constructor that accepts an IEnumerable(of T).
        Stack<string> stack3 = new(array2);

        Console.WriteLine("\nContents of the second copy, with duplicates and nulls: ");
        foreach (string number in stack3)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"\nstack2.Contains(\"four\") = {stack2.Contains("four")}");
        Console.WriteLine("\nstack2.Clear()");
        stack2.Clear();
        Console.WriteLine($"\nstack2.Count = {stack2.Count}");
    }
    }

/* This code example produces the following output:
five
four
three
two
one
Popping 'five'
Peek at next item to destack: four
Popping 'four'
Contents of the first copy:
one
two
three
Contents of the second copy, with duplicates and nulls:
one
two
three
stack2.Contains("four") = False
stack2.Clear()
stack2.Count = 0
 */
