using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgcookingBackend.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace HackerrankTest
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(mergeStrings("dsflksjdf", "sdf92112112121"));
                //Console.WriteLine(mergeStrings("abc", "dfe111"));
                Console.ReadLine();
            }
            //the output is :
            //dssdffl9k2s1j1d2f112121
            

            //adbfce

    /*        
        static string mergeStrings(string a, string b)
        {

            string[] mergedString = new string[50000];

            int k = 0;
            int h = 1;

            for (int i = 0; i < a.Length; i++)
            {
                mergedString[k] = a[i].ToString();
                k = k + 2;
            }

            for (int i = 0; i < b.Length; i++)
            {
                mergedString[h] = b[i].ToString();
                h = h + 2;
            }

            string result = string.Join("", mergedString);
            return (result);

        }
        
  */      
            static string mergeStrings(string a, string b)
            {
                string result= "";
                int min = Math.Min(a.Length, b.Length);
                int index = 0;

                for (int i = 0 ; i < min ; i++)
                {
                    result += a[i];
                    result += b[i];
                    index = i+1;
                }

                if (a.Length > b.Length)
                {
                    result += a.Substring(index, a.Length - index);
                }
                else
                {
                    result += b.Substring(index, b.Length - index);
                }
                return result;
            }
            
    
        }
    }



}
