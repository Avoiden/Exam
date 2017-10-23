using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Test_C___C__
{
    /// <summary>
    /// <remarks>It`s a class for students</remarks>
    /// </summary>
    class Student
    {
        /// <summary>
        /// <remarks>It`s a method for Outputing the test</remarks>
        /// </summary>
        /// <param name="TPass"></param>
        public void ExamOutput(string TPass)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Your test:");
                Console.WriteLine(File.ReadAllText(TPass));
                Console.WriteLine();
                Console.WriteLine("Whenever you`re ready for the test, press Enter...");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// <remarks>It`s a method for Filling the test</remarks>
        /// </summary>
        /// <param name="Spath"></param>
        public void ExamFilling(string Spath)
        {
            StreamWriter sw2 = null;
            int stat = 0;
            try
            {
                Console.WriteLine("Exam started!");
                for (var i = 0; i < 10; i++)
                {
                    if (Spath == "D:\\Test\\Tests\\C++.txt")
                    {
                        StreamReader sr = new StreamReader(@"D:\Test\Answers\Answers(C++).txt", true);
                        Console.WriteLine("{0} question", i);
                        sr.ReadLine();
                        Console.WriteLine("Your answer:");
                        string s = Console.ReadLine();
                        string buf = sr.ReadLine();
                        if (buf.CompareTo(s) != 0)
                        {
                            sw2.WriteLine("Wrong answer!");
                        }
                        else
                        {
                            stat+=10;
                            sw2.WriteLine("Write answer!");
                        }
                    }
                    if (Spath == "D:\\Test\\Tests\\C.txt")
                    {
                        StreamReader sr = new StreamReader(@"D:\Test\Answers\Answers(C).txt", true);
                        Console.WriteLine("{0} question", i);
                        sr.ReadLine();
                        Console.WriteLine("Your answer:");
                        string s = Console.ReadLine();
                        string buf = sr.ReadLine();
                        if (buf.CompareTo(s) != 0)
                        {
                            sw2.WriteLine("Wrong answer!");
                        }
                        else
                        {
                            stat += 10;
                            sw2.WriteLine("Write answer!");
                        }
                    }
                }
                sw2.WriteLine(stat);
                Console.WriteLine("Exam is over.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(sw2!=null)
                {
                    sw2.Close();
                    sw2 = null;
                }
            }
        }
    }
}
