using System;
using System.IO;

class Program
{
    static void TestCatch()
    {
        System.IO.StreamWriter sw = null;

        try
        {
            sw = new System.IO.StreamWriter(@"C:\temp\test.txt");
            sw.WriteLine("Hello");
        }
        catch (System.IO.FileNotFoundException ex)
        {
           
            System.Console.WriteLine(ex.ToString());
        }
        catch (System.IO.IOException ex)
        {
            
            System.Console.WriteLine(ex.ToString());
        }
        finally
        {
            if (sw != null)
            {
                sw.Close();
            }
            System.Console.WriteLine("Done");
        }
    }

    static void Main(string[] args)
    {
        TestCatch();
    }
}



