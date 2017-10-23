using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_C___C__
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Directory.CreateDirectory(@"D:\Statistics");
                string key = null;
                do{
                Console.WriteLine("Who are you?");
                Console.WriteLine("1-student");
                Console.WriteLine("2-teacher");
                Console.WriteLine("3-Exit");
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Clear();
                        Student std = new Student();
                        Console.WriteLine("Input exam path, that your teacher has given to you:");
                        string path = Console.ReadLine();
                        std.ExamOutput(path);
                        std.ExamFilling(path);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you a new teacher, or an existing one?\n1-New one\n2-Existing");
                        key = Console.ReadLine();
                        switch (key)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Input your Name:");
                                string tName = Console.ReadLine();
                                Console.WriteLine("Input your Password:");
                                string tPass = Console.ReadLine();
                                Teacher t = new Teacher(tPass, tName);
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Input your Name and Password Like that: Name - Password");
                                string Password = Console.ReadLine();
                                Teacher t2 = new Teacher(Password);
                                string i = null;
                                do
                                {
                                    Console.WriteLine("What would you like to do?");
                                    Console.WriteLine("1-Create a test");
                                    Console.WriteLine("2-Delete a test");
                                    Console.WriteLine("3-Exit");
                                    i = Console.ReadLine();
                                    switch (i)
                                    {
                                        case "1":
                                            Console.Clear();
                                            Console.WriteLine("Input the path to your test(D:\\Test\\Tests\\Name.txt):");
                                            string CreateTest = Console.ReadLine();
                                             Console.WriteLine("Input the path to your answers(D:\\Test\\Answers\\Name.txt):");
                                            string CreateAnswer = Console.ReadLine();
                                            t2.TestCreate(CreateTest, CreateAnswer);
                                            break;
                                        case "2":
                                            Console.Clear();
                                            Console.WriteLine("Input the path to your test(D:\\Test\\Tests\\Name.txt):");
                                            string DelPath = Console.ReadLine();
                                            t2.TestDelete(DelPath);
                                            break;
                                        default:
                                            break;
                                    }
                                } while (i != "3");
                                break;
                        }
                        //t.TestCreate(@"D:\Test.txt");
                        break;
                    default:
                        break;
                }
                }while(key != "3");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("Unhandled exception!");
            }
            finally
            {

            }
        }
    }
}
