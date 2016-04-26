using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwoFileIdenticalOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file1;
            byte[] dataFile1;
            FileStream file2;
            byte[] dataFile2;

            bool result = true;
            try
            {
            //here you can change the Frist File (file1)
            file1 = File.OpenRead("C:\\Konyvek\\test1.txt");
            dataFile1 = new byte[file1.Length];
            file1.Read(dataFile1, 0,  (int)file1.Length);
            

            //here you can change the Frist File (file2)
            file2 = File.OpenRead("C:\\Konyvek\\test2.txt");
            dataFile2 = new byte[file2.Length];
            file2.Read(dataFile2, 0, (int)file2.Length);
            
            
                if (dataFile1 == dataFile2)
                {
                    for (int i = 0; i < dataFile1.Length; i++)
                    {
                        if (dataFile1[i] != dataFile2[i])
                        {
                            result = false;
                        }
                    }
                }
                else
                {
                    result = false;
                }
                if (result)
                {
                    Console.WriteLine("The files are identical!");
                }
                else
                {
                    Console.WriteLine("The files are not identical!");
                }
                file1.Close();
                file2.Close();
                Console.ReadLine();
            } catch(ObjectDisposedException e)
            {
                Console.WriteLine("Error: {0}",e.Message);
            } catch(FileNotFoundException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            
            Console.ReadLine();

        }
    }
}
