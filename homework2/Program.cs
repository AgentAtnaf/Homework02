class Program
{
    static void Main(string[] args)
    {
        int exit = 1;
        int x = -1;
        CircularLinkedList<char> circularLinkedList = new CircularLinkedList<char>();
        Queue<char> queue = new Queue<char>();
        Console.WriteLine("Input.");
        do
        {
          x++;
          circularLinkedList.Add(char.Parse(Console.ReadLine()));
          if(circularLinkedList.Get(x) != 'L' && circularLinkedList.Get(x) != 'M' && circularLinkedList.Get(x) != 'S')
          {
            circularLinkedList.Remove(x);
            exit = 1;
          }
          else if(circularLinkedList.Get(x) == 'L')
          {
            circularLinkedList.Set(x,'1');
            queue.Push('1');
                      exit = 0;
          }
          else if(circularLinkedList.Get(x) == 'M')
          {
            circularLinkedList.Set(x,'2');
            queue.Push('2');
                      exit = 0;
          }
          else if(circularLinkedList.Get(x) == 'S')
          {
            circularLinkedList.Set(x,'3');
            queue.Push('3');
                      exit = 0;
          }
        }
        while( exit == 0);

        int l = 0;
        int n = 0;
        while(l == 0)
        {
        for(n = 0; n < queue.GetLength(); n++)
        {
            if(queue.Get(n) == '1')
            {
              queue.Push('2');
              queue.Push('2');
            }
            else if(queue.Get(n) == '2')
            {
              queue.Push('3');
              queue.Push('3');
              queue.Push('3');
            }
        }
        for( n = 0; n < queue.GetLength(); n++)
            {
            //Console.WriteLine(circularLinkedList.GetLength());
             Console.Write(queue.Get(n));
            }
            if(n == queue.GetLength())
            {
              l = 1;
            }
        }
    }  
}

/*for(int l = 0; l < circularLinkedList.GetLength(); l++)
            {
            //Console.WriteLine(circularLinkedList.GetLength());
             Console.Write(circularLinkedList.Get(l));
            }*/