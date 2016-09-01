﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        //-----Translation------
        static public string PigLat(string str)
        {
            char first = str[0];
            int count = 0;
            if (VowelCheck(str, 0))
            {
                return str + "way";
            }
            //------Vowel Check-------
            string ending = "";
            foreach (char c in str)
            {
                //------If not a vowel------
                if (!VowelCheck(char.ToString(c), 0))
                {
                    ending = ending + c;
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.Write(str.Substring(count) + ending + "ay"); //Comment out for tests
            return ""; //return str.Substring(count) + ending + "ay"; (for testing)
        }
        //-----Vowel?------
        static public bool VowelCheck(string str, int count)
        {
            char current = str[count];
            if (current == 'a' || current == 'e' || current == 'i' || current == 'o' || current == 'u')
            {
                return true;
            }
            else if (current == '@' || current == '1' || current == '-' || current == '$')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //-----Continue?------
        static public bool Cont(string con)
        {
            if (con == "y")
            { return true; }
            else
            { return false; }
        }
        //-----Palindrome?------
        static public void Palin(string str)
        {

            if (str.First() == str.Last())
            {
                if (str.Length == 1)
                { Console.WriteLine("Is a palindrome"); }
                else
                {
                    str = str.Trim(str.First());
                    Palin(str);
                }
            }
            else
            { Console.WriteLine("Is not a palindrome"); }

        }
    }
}
