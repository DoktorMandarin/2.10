using System;

namespace _2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var number = random.Next();
            int x = 2;
            var stepen = 0;
            Console.WriteLine(number);

           
            for (var i = 0; ; i++)
            {
                if (number > Math.Pow(x, stepen))
                {
                    stepen = i;
                                        
                }
             Console.WriteLine($"{number}, степень = {stepen} {Math.Pow(x, stepen)}");              
                
            }
            
        }
    }
    
}
