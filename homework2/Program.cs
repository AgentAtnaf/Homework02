class Program
{
    static void Main(string[] args)
    {
        int exit = 1;
        int x = -1;
        int split = 0;
        CircularLinkedList<char> circularLinkedList = new CircularLinkedList<char>();
        Console.WriteLine("Input.");
        do
        {
          x++;
          circularLinkedList.Add(char.Parse(Console.ReadLine()));
          char checkout = circularLinkedList.Get(x);
          if(checkout == 'L' || checkout == 'M' || checkout == 'S')
          {
            if(checkout == 'L')
            {
                circularLinkedList.Remove(x);
                circularLinkedList.Insert(x,'1');
            }
            else if(checkout == 'M')
            {
                circularLinkedList.Remove(x);
                circularLinkedList.Insert(x,'2');
            }
            else if(checkout == 'S')
            {
                circularLinkedList.Remove(x);
                circularLinkedList.Insert(x,'3');
            }
            exit = 0;
          }
          else 
          {
            exit = 1;
            circularLinkedList.Remove(x);
          }
        }
        while( exit == 0);

         
        for(int i = 0; i < circularLinkedList.GetLength(); i++)
        {
        //Console.WriteLine(circularLinkedList.GetLength());
        Console.Write(circularLinkedList.Get(i));
        }
               
        while(split == 0)
        {
        for(int i = 0; i < circularLinkedList.GetLength();i++)
        {
            if(circularLinkedList.Get(i) == '3' || circularLinkedList.Get(i) == '2' || circularLinkedList.Get(i) == '1')
            {
                if(circularLinkedList.Get(i) == '1')
                {
                    circularLinkedList.Set(i,'2');
                    Console.Write(" (4) {0} |{1}|",circularLinkedList.Get(i),i);
                    circularLinkedList.Insert(i+1,'2');
                    Console.Write(" (5) {0} |{1}|",circularLinkedList.Get(i+1),i+1);
                    i++;
                }
                else if(circularLinkedList.Get(i) == '2')
                {
                    circularLinkedList.Set(i,'3');
                    Console.Write(" (1) {0} |{1}|",circularLinkedList.Get(i),i);
                    circularLinkedList.Insert(i+1,'3');
                    Console.Write(" (2) {0} |{1}|",circularLinkedList.Get(i+1),i+1);
                    circularLinkedList.Insert(i+2,'3');
                    Console.Write(" (3) {0} |{1}|",circularLinkedList.Get(i+2),i+2);
                    i = i + 2;
                }
                else if(circularLinkedList.Get(i) == '3')
                {
                    circularLinkedList.Remove(i);
                    i--;
                }
                else
                {
                    split = 0;
                }
            }
            else 
            {
                split = 1;
            }    
        }
        split = 1;
    }   
}
}
