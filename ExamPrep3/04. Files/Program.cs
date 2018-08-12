using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex checkFileNameExtension = new Regex(@"\w+\.\w+");
            List <File> files= new List<File>();

            for (int currFile = 0; currFile < n; currFile++)
            {
                List<string> fileDirectoryProp = Console.ReadLine().Split(new char []{'\\', ';'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int i = 0; i < fileDirectoryProp.Count; i++)
                {
                    if (checkFileNameExtension.IsMatch(fileDirectoryProp[i]))
                    {
                        string[] extAndName = fileDirectoryProp[i].Split('.');
                        File file = new File {
                            Root = fileDirectoryProp[0],
                            FileName = extAndName[0],
                            Extension = extAndName[1],
                            Size = long.Parse(fileDirectoryProp[i + 1])
                        };

                        for (int fileInFiles = 0; fileInFiles < files.Count; fileInFiles++)
                        {
                            if ((files[fileInFiles].Root == file.Root) && (files[fileInFiles].Extension == file.Extension)
                                && (files[fileInFiles].FileName == file.FileName))
                            {
                                files.Remove(files[fileInFiles]);
                                break;
                            }
                        }
                        files.Add(file);
                    }
                }
            }

            List<string> outProp = Console.ReadLine().Split(' ').ToList();
            bool haveResult = false;

            files = files.OrderByDescending(p => p.Size).ThenBy(p => p.FileName).ToList();

            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Root == outProp[2] && files[i].Extension == outProp[0])
                {
                    Console.WriteLine($"{files[i].FileName}.{files[i].Extension} - {files[i].Size} KB");
                    haveResult = true;
                }
            }

            if (!haveResult)
            {
                Console.WriteLine("No");
            }
        }
        
        class File
        {
            public string Root { get; set; }
            public string FileName { get; set; }
            public string Extension { get; set; }
            public long Size { get; set; }
        }

    }
}
