using System.Runtime.Intrinsics.Arm;

namespace AlgorithmPrograms
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int a, b, rev, rem, flag;
            Console.WriteLine("Enter lower bound of " + "the interval: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter upper bound " + "of the interval: ");
            b = int.Parse(Console.ReadLine());

                int num, temp;
                Console.WriteLine("Prime numbers between " + "{0} and {1} are: ", a, b);
                for (num = a; num <= b; num++)
                {
                    flag = 0;
                    rev = 0;
                    temp = num;
                    for (int i = 1; i <= temp; i++)
                    {
                        if (temp % i == 0)
                        {
                            flag++;
                        }
                    }
                    if (flag == 2)
                    {
                        while (temp > 0)
                        {
                            rem = temp % 10;
                            rev = rev * 10 + rem;
                            temp = temp / 10;

                        }
                        if (rev == num)
                        {
                            Console.WriteLine(num + "");
                        }
                    }
                }

            
        }
        
    } 
}
