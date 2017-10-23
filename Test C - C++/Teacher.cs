using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_C___C__
{
    /// <summary>
    /// <remarks>It`s a class for teachers</remarks>
    /// </summary>
    class Teacher
    {
        const string TPass = ("D:\\Teacher\\Passwords\\Passwords.txt");
        /// <summary>
        /// <remarks>It`s a constructor for existing teacher</remarks>
        /// </summary>
        /// <param name="Password"></param>
        public Teacher(string Password)
        {
            StreamReader sr = null;
            string buf = null;
            try
            {
                sr = new StreamReader(TPass, true);
                buf = sr.ReadLine();
                if(buf.CompareTo(Password)!=0)
                {
                    Console.WriteLine("Sorry, your Name or Password is invalid!");
                    return;
                }
                Console.WriteLine("Your welcome!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr = null;
                }
            }    
        }
        /// <summary>
        /// <remarks>It`s a constructor for new teacher</remarks>
        /// </summary>
        /// <param name="Password"></param>
        /// <param name="Name"></param>
        public Teacher(string Password,string Name)
        {
            Directory.CreateDirectory(@"D:\Teacher\Passwords");
            StreamWriter sw = null;
            FileStream fs = null;
            try
            {
                if (!File.Exists(TPass))
                    fs = new FileStream(TPass, FileMode.OpenOrCreate);
                sw = new StreamWriter(TPass, true);
                sw.WriteLine("{0} - {1}", Name, Password);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(sw!=null)
                {
                    sw.Close();
                    sw = null;
                }
                if(fs!=null)
                {
                    fs.Close();
                    fs = null;
                }
            }    
        }
        /// <summary>
        /// <remarks>It`s a method for creating tests</remarks>
        /// </summary>
        /// <param name="CreateName"></param>
        public void TestCreate(string CreateTest,string CreateAnswer)
        {
            Directory.CreateDirectory(@"D:\Test\Tests");
            Directory.CreateDirectory(@"D:\Test\Answers");
            StreamWriter swT = null;
            StreamWriter swA = null;
            try
            {
                swT = new StreamWriter(CreateTest);
                swA = new StreamWriter(CreateAnswer);
                string s;
                for (var i = 0; i < 10; i++) 
                {
                    Console.WriteLine("Input {0} question...", i+1);
                    s = Console.ReadLine();
                    swT.WriteLine(s);
                }
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine("Input {0} answer...", i + 1);
                    s = Console.ReadLine();
                    swA.WriteLine(s);
                }
                Console.WriteLine("Exam is filled, thanks!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(swT!=null)
                {
                    swT.Close();
                    swT = null;
                }
                if (swA != null)
                {
                    swA.Close();
                    swA = null;
                }
            }
        }
        /// <summary>
        /// <remarks>It`s a method for deleting tests</remarks>
        /// </summary>
        /// <param name="DelPath"></param>
        public void TestDelete(string DelPath)
        {
            try
            {
                File.Delete(DelPath);
                Console.WriteLine("Test deleted successfully!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
    }
}
