using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HostSandNumberOfRequests
{
    public class Host
    {
        public string Name { get; set; }
        public int CountOfOccurrance { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string fileName = Console.ReadLine();

            string[] logRecordsLines = new string[0];

            List<Host> hostList = new List<Host>();
            string[] lines = File.ReadAllLines(@"C:\Users\RafiB\Desktop\HostLogHacker.txt");

            if (lines.Length > 2 * (Math.Pow(10, 5)))

            {

                Console.WriteLine("There must be less then 2 * 10^5 log records");
            }
            else
            {


            
         
            int count = 0;
            string path = @"c:\Users\RafiB\Desktop\";
                using (StreamWriter sw = File.CreateText(path + fileName + ".Txt"))
                {


                    for (int i = 0; i < lines.Length; i++)
                    {
                        Host oHost = new Host();

                        logRecordsLines = lines[i].Split('-');

                        //sw.WriteLine(logRecordsLines[0]);
                        oHost.Name = logRecordsLines[0];
                        hostList.Add(oHost);

                    }

                    for (int i = 0; i < hostList.Count; i++)
                    {
                        //Get count of current element to before:
                        int countOfHost = hostList.Take(i + 1)
                            .Count(r => r.Name == hostList[i].Name);
                        hostList[i].CountOfOccurrance = countOfHost;
                    }

                    var uniqueHostsWithOccurances =
                        hostList.GroupBy(s => s.Name)
                            .Select(g => new {HostName = g.Key, Count = g.Max(y => y.CountOfOccurrance)});




                    foreach (var e in uniqueHostsWithOccurances)
                    {

                        sw.WriteLine("{0}-{1}", e.HostName,
                            e.Count);
                        Console.WriteLine("{0}-{1}", e.HostName,
                            e.Count);

                    }



                }



            }

        }

    }
}
    
