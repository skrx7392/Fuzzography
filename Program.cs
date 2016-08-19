using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGeoNames;

namespace Fuzzography
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> cityInput = new List<KeyValuePair<string, string>>();
            try
            {
                using (StreamReader input1 = new StreamReader("..//..//input1.txt"))
                {
                    while (input1.Peek()>0)
                    {
                        string[] line = input1.ReadLine().Split('|');
                        KeyValuePair<string, string> temp = new KeyValuePair<string, string>(line[0], line[1]);
                        cityInput.Add(temp);
                    }
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Dictionary<string, string> countryInput = new Dictionary<string, string>();
            try
            {
                using (StreamReader input2 = new StreamReader("..//..//input2.txt"))
                {
                    while (input2.Peek() > 0)
                    {
                        string[] line = input2.ReadLine().Split('|');
                        countryInput.Add(line[0], line[1]);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
