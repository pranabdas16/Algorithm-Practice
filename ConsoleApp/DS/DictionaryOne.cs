using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp.DS
{
    class DictionaryOne
    {
        public void dictionaryOne()
        {
            Dictionary<int, int> objDic = new Dictionary<int, int>()
            {
                { 1, 10 },
                { 2, 20 },
                { 3, 30 },
                { 4, 40}
            };

            objDic.Add(7, 98);
            //for (int i = 0;  i < objDic.Count; i++)
            //{
            //    Console.WriteLine(objDic.Keys[i] + " " + objDic.Values);
            //}
            foreach (KeyValuePair<int, int> var in objDic)
            {
                Console.WriteLine("Key = {0}, Value = {1}", var.Key, var.Value);
            }

            Hashtable objhashtable = new Hashtable();

            objhashtable.Add(1, 25);
            objhashtable.Add(2, 23);
            objhashtable.Add(3, "Hello");

            foreach (DictionaryEntry jar in objhashtable)
            {
                Console.WriteLine("keyHash = {0}, valueHash = {1}", jar.Key, jar.Value);
            }


        }
    }
}
