using System;
 
namespace ConsoleApplication
{
    class Program
    {
        
        public static UInt64 AckermannFunc(UInt64 m, UInt64 n) {
            
            if (m == 0)
                return n + 1;
            if (m > 0)
                if (n == 0)
                    return AckermannFunc(m - 1, 1);
            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }
        
        public static void Main(string[] args) {
            Console.WriteLine(AckermannFunc(2, 3));
            
        }
    }
}