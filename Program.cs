using System;
using System.Collections;
using System.Collections.Generic;


namespace leetcode
{
    class Program
    {
        public static void Main(string[] args)  
        {
            int n = 5;
            string blah =  CountAndSay(n);
            Console.WriteLine(blah);
        } 

        public static string CountAndSay(int n) {
        string s = "1";
        for (int i = 1; i < n; i++) {
            string tmp = "";
            int cnt = 1;
            for (int j = 1; j < s.Length; j++) {
                if (s[j - 1] == s[j])
                    cnt += 1;
                else  {
                    tmp += cnt.ToString() + s[j - 1];
                    cnt = 1;
                }
            }
            s = tmp + cnt.ToString() + s[s.Length - 1];
        }
        return s;
    }
       
    }

}
