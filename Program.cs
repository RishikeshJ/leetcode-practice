using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Problem: 
//https://leetcode.com/problems/minimum-subsequence-in-non-increasing-order/

namespace leetcode
{
    class Program
    {
        public static void Main(string[] args)
        {
            // int[] number = {4,3,10,9,8};
            string[] s = {"900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
            IList<string> test = SubdomainVisits(s);
            foreach(var item in test){
                Console.WriteLine(item);
            }
        }

        public static IList<string> SubdomainVisits(string[] cpdomains) {
            List<string> finalList = new List<string>();
            List<string> subdomainList = new List<string>();

            Dictionary<string,int> keyvaldict = new System.Collections.Generic.Dictionary<string, int>();
            foreach(var item in cpdomains){
                item.Replace(',',' ');
                string[] splitArr = item.Split(' ');
                keyvaldict.Add(splitArr[1],int.Parse(splitArr[0]));
            }


            foreach(var thing in keyvaldict){
                Console.WriteLine(thing);
            }
            return finalList;
                
        }
    }
}

