using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_C___C__
{
    class FileOperations
    {
        public void FileRead(string s)
        {
            try
            {
                Console.WriteLine(File.ReadAllText(s));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
        //public string FindInFile(string FilePath)
        //{

        //}
    }
}
