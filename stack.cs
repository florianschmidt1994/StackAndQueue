using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Neuen Stack erstellen
        Stack<String> myStack = new Stack<String>();
        
        // "A" auf den Stack legen
        myStack.Push("A");
        PrintStack(myStack);
        
        // "F" auf den Stack legen
        myStack.Push("F");
        PrintStack(myStack);
        
        // "C" auf den Stack legen
        myStack.Push("C");
        PrintStack(myStack);
        
        // Das oberste Element vom Stack herunternehmen --> "C"
        String top = myStack.Pop();
        Console.Out.WriteLine("\n"+top+" wurde vom Stack genommen\n");
        PrintStack(myStack);
        
        // Das oberste Element vom Stack herunternehmen --> "F"
        top = myStack.Pop();
        Console.Out.WriteLine("\n"+top+" wurde vom Stack genommen\n");
        PrintStack(myStack);
        
        // "B" auf den Stack legen
        myStack.Push("B");
        PrintStack(myStack);
    }
    
    static void PrintStack(Stack<String> myStack) {
        Array myArray = myStack.ToArray();
        Console.Out.WriteLine("\nAktueller Stack:");
        foreach (object i in myArray) {
            Console.Out.WriteLine(" "+i);
        }
        Console.Out.WriteLine("---");
    }
}
