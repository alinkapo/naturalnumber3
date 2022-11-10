namespace natural_number__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Введите любые три числа:");
          var S = Console.ReadLine();

          var a = Convert.ToInt32(S[0]);
          var b = Convert.ToInt32(S[1]);
          var c = Convert.ToInt32(S[2]);

          int D = a;
          if ((a < b && b < c) || (a > b && b > c))
          {    
            D = b;
          }
          else 
          if ((a > b && a < c) || (a > c && a < b))
          {
            D = c;
          }
            Console.WriteLine("Среднее число, которое вывелось из них:");
            Console.WriteLine(D);
        }
    }
}
    
