using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo(@"D:\VIGNESH G\CSharp\FileIOManipulation");
            //dir.Create();
            //FileInfo file = new FileInfo(@"D:\VIGNESH G\CSharp\FileIOManipulation\sample.txt");
            //file.Create();
            FileStream fs = new FileStream(@"D:\VIGNESH G\CSharp\FileIOManipulation\sample.txt", FileMode.OpenOrCreate,
                FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is the line we have Entered in the sample text file -_-");
            sw.Close();
            fs.Close();
            fs=new FileStream(@"D:\VIGNESH G\CSharp\FileIOManipulation\sample.txt", FileMode.Append,
                FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(fs);
            sw1.WriteLine("This is appended to the Txt file");
            sw1.Close();
            fs.Close();
            Console.WriteLine("Content has been written to text file");
            fs = new FileStream(@"D:\VIGNESH G\CSharp\FileIOManipulation\sample.txt", FileMode.OpenOrCreate,
               FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
             var content = sr.ReadToEnd();
            //string linebYline;
            //while ((linebYline =sr.ReadLine())!=null)
            Console.WriteLine("{0}", content);
            

            sr.Close();
            fs.Close();

        }
    }
}
