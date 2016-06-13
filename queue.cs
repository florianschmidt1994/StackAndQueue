using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<String> myQueue = new Queue<String>();
        
        myQueue.Enqueue("A");
        PrintQueue(myQueue);
        
        myQueue.Enqueue("F");
        PrintQueue(myQueue);
        
        myQueue.Enqueue("C");
        PrintQueue(myQueue);
        
        String begin = myQueue.Dequeue();
        Console.Out.WriteLine("\nVom Anfang entfernt: "+begin);
        PrintQueue(myQueue);
        
        begin = myQueue.Dequeue();
        Console.Out.WriteLine("\nVom Anfang entfernt: "+begin);
        PrintQueue(myQueue);
        
        myQueue.Enqueue("B");
        PrintQueue(myQueue);
        
    }
    
    static void PrintQueue(Queue<String> myQueue) {
        Console.Out.Write("\nAktuelle Queue:");
        foreach (object i in myQueue) {
            Console.Out.Write(" "+i);
        }
        Console.Out.WriteLine("");
    }
}
