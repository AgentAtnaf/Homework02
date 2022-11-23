class Program
{
    static void Main(string[] args)
    {
        int exit = 1;
        int x = -1;
        CircularLinkedList<char> circularLinkedList = new CircularLinkedList<char>();
        do
        {
        x++;
        circularLinkedList.Add(char.Parse(Console.ReadLine()));
        char current = circularLinkedList.Get(x);
        if(current != 'J' && current != 'G' && current != 'O' && current != 'R')
        {
          circularLinkedList.Remove(x);
          x--;
          exit = 2;
        }
        else if(circularLinkedList.Get(x) == 'R' && circularLinkedList.GetLength() == 1)
        {
            {
            Console.WriteLine("Ivalid pattern 1.",circularLinkedList.Get(x));
            x--;
            }
        }
        else if(circularLinkedList.Get(0) == 'R')
        {
            circularLinkedList.Remove(0);
        }
        else if(circularLinkedList.Get(x) == 'R' && circularLinkedList.GetLength() > 1)
            {
                if(circularLinkedList.Get(x-1) == 'R')
                {
                Console.WriteLine("Ivalid pattern 2.");
                circularLinkedList.Remove(x);
                x--;  
                }
                else if(circularLinkedList.Get(x+1) == circularLinkedList.Get(x-1) && circularLinkedList.GetLength() > 3) 
                {
                Console.WriteLine("Ivalid pattern 3.");
                circularLinkedList.Remove(x);
                x--;  
                }
                else exit = 1;
            }
        else if(circularLinkedList.Get(x) == 'J' && circularLinkedList.Get(x-1) == 'R' && circularLinkedList.Get(x-2) == 'J'&& circularLinkedList.GetLength() > 2)
            {
            Console.WriteLine("Ivalid pattern 4.");
            circularLinkedList.Remove(x);
            x--; 
            }
        else if(circularLinkedList.Get(x) == 'O' && circularLinkedList.Get(x-1) == 'R' && circularLinkedList.Get(x-2) == 'O'&& circularLinkedList.GetLength() > 2)
            {
            Console.WriteLine("Ivalid pattern 5.");
            circularLinkedList.Remove(x);
            x--; 
            }
        else if(circularLinkedList.Get(x) == 'G' && circularLinkedList.Get(x-1) == 'R' && circularLinkedList.Get(x-2) == 'G' && circularLinkedList.GetLength() > 2)
            {
            Console.WriteLine("Ivalid pattern 6.");
            circularLinkedList.Remove(x);
            x--; 
            }
        else if(circularLinkedList.Get(x) == 'G' && circularLinkedList.GetLength() > 3)
            {
            if(circularLinkedList.Get(x-1) == 'G' && circularLinkedList.Get(x-2) == 'G' && circularLinkedList.Get(x-3) == 'G')
                {
                Console.WriteLine("Ivalid pattern 7.");
                circularLinkedList.Remove(x);
                x--;
                }
            else if(circularLinkedList.Get(x+1) == 'G' && circularLinkedList.Get(x+2) == 'G' && circularLinkedList.Get(x+3) == 'G')
                {
                Console.WriteLine("Ivalid pattern 8.");
                circularLinkedList.Remove(x);
                x--;
                }
            else if(circularLinkedList.Get(x-1) == 'G' && circularLinkedList.Get(x+1) == 'G' && circularLinkedList.Get(x+2) == 'G')
                {
                Console.WriteLine("Ivalid pattern 9.");
                circularLinkedList.Remove(x);
                x--;
                }
            else if(circularLinkedList.Get(x-2) == 'G' && circularLinkedList.Get(x-1) == 'G' && circularLinkedList.Get(x+1) == 'G')
                {
                Console.WriteLine("Ivalid pattern 10.");
                circularLinkedList.Remove(x);
                x--;
                }
            else exit = 1;
            }
        else exit = 1;
        }
        while(exit == 1);
        
        for (int i = 0; i < circularLinkedList.GetLength(); i++) 
        {
        Console.Write(circularLinkedList.Get(i));
        //Console.WriteLine(circularLinkedList.GetLength());
        //Console.WriteLine("next node {0}",circularLinkedList.Get(i+1));  
        }
    }
}