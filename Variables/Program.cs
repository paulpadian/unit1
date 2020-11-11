using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        //    System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
           
        //    const float Pi = 3.14f;
        //    string s = "1";
         
        //    int j = Convert.ToInt32(s);
        //    System.Console.WriteLine(j);
        //    int i = 1;
        //    byte b = (byte) i;
        //    System.Console.WriteLine(b);
            try
            {
                // var number = "1234";
                // byte b = Convert.ToByte(number);
                // Console.WriteLine(b);
                string str = "true";
                bool b = Convert.ToBoolean(str);
                System.Console.WriteLine(b);

                
            }
            catch (System.Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
                throw;
            }

            //this is a comment
            /*
            This is 
            a
            multiline comment
            */
        
        }
    }
}
