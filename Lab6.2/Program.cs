using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2
{
    class Program
    {
        public static void my(String path, String dir)
        {
            String filename = Path.Combine(path, dir);
            DirectoryInfo directoryInfo = new DirectoryInfo(filename);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            else
            {
                Console.WriteLine("此文件夹已经存在");
            }
        }
        static void Main(string[] args)
        {
            String str = "厦门大学软件学院 软件工程2016级.\n";
            String path = "d:\\temp";
            String strfilename = Path.Combine(path, "test.txt");
            Console.WriteLine(strfilename);
            DirectoryInfo directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }
            else
            {
                Console.WriteLine("此文件夹已经存在");

            }

            FileStream fileStream = new FileStream(strfilename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(str);
            streamWriter.Close();
            fileStream.Close();
            my(path, "Temp1");
            my(path, "Temp2");
            my(path, "Temp3");
            System.Console.Read();
        }

    }
}
