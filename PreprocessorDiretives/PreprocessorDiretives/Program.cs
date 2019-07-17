#define MYTEST
using System;

namespace PreprocessorDiretives
{
#pragma warning disable 414, CS3021
    [CLSCompliant(false)]
    public class Program
    {
        static void Main(string[] args)
        {
            #region IF
#if (DEBUG && !MYTEST)
                Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && MYTEST)
        Console.WriteLine("MYTEST is defined");
#elif (DEBUG && MYTEST)
            Console.WriteLine("DEBUG and MYTEST are defined");
#else
        Console.WriteLine("DEBUG and MYTEST are not defined");
#endif
        }
    }
    #endregion

    #region PRAGMA
#pragma warning restore CS3021
    [CLSCompliant(false)]  // CS3021  
    public class D
    {
        int i = 1;
        public static void F()
        {
            // Rules
        }
    }
    #endregion
}