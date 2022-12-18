int num, I, sum, start, end;

Console.WriteLine("starting Number");

start = int.Parse(Console.ReadLine());

Console.WriteLine("Ending Number");

end = int.Parse(Console.ReadLine());

for (num = start; num <= end; num++)
{ 

   sum = 0;
    for (I = 2; I <= num / 2; I++)
    {

        if (num % I == 0)
        {
            sum++;
            break;
        }
    }
         if (sum == 0 && num != 1 && num != 0)
         Console.WriteLine("{0}", num);
     

 }
            Console.WriteLine("Thanks For Using My Program");
            Console.ReadKey();
        
    
