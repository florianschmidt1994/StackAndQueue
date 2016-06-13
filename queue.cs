using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Neue Queue erzeugen
        Queue<String> myQueue = new Queue<String>();
        
        // "A" an die Queue anhängen
        myQueue.Enqueue("A");
        PrintQueue(myQueue);
        
        // "F" an die Queue anhängen
        myQueue.Enqueue("F");
        PrintQueue(myQueue);
        
        // "C" an die Queue anhängen
        myQueue.Enqueue("C");
        PrintQueue(myQueue);
        
        // Vorderstes Element von der Queue entfernen
        String begin = myQueue.Dequeue();
        Console.Out.WriteLine("\nVom Anfang entfernt: "+begin);
        PrintQueue(myQueue);
        
        // Vorderstes Element von der Queue entfernen
        begin = myQueue.Dequeue();
        Console.Out.WriteLine("\nVom Anfang entfernt: "+begin);
        PrintQueue(myQueue);
        
        // "B" an die Queue anhängen
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
