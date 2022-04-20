using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using HackerRankConsoleApp.LeetCode;
using System.Text;
using System;


namespace HackerRankConsoleApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            //string str = "leetcode";
            //FirstUniqChar objFUC = new FirstUniqChar();
            //objFUC.firstUniqchar(str);


            //int[][] mat1 = { new int []{ 1,2}, new int[] {3,4 } };
            //MatrixReshape objMR = new MatrixReshape();
            //objMR.matrixReshape(mat1, 2, 2);

            //string haystack = "aaaaaa", needle = "bba";
            //StrString objStrString = new StrString();
            //objStrString.StrStr1(haystack, needle);

            RepSubstringPattern objRSP = new RepSubstringPattern();
            objRSP.RepeatedSubstringPattern("abcabc");


        }


        /// <summary>
        /// https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
        /// </summary>
        /// <returns></returns>
        #region working code for climbing Leadboard...
        //public static List<int> climbingLeaderboard()//List<int> ranked, List<int> player)
        //{
        //    List<int> objList = new List<int>();//remove this if not needed..

        //    List<int> ranked = new List<int>() { 100, 100, 50, 40, 40, 20, 10 };//This will be removed since this is already given..
        //    int[] scores = ranked.ToArray();
        //    List<int> player = new List<int>() { 5, 5, 6, 10, 15,    25, 20, 40, 50, 50, 100, 120 };//This will be removed since this is already given..
        //    int[] alice = player.ToArray();
        //    //int[] scores = ranked.ToArray();
        //    //int[] alice = player.ToArray();
        //    int n = scores.Length;
        //    int m = alice.Length;

        //    int [] res = new int[m];
        //    int[] rank = new int[n];

        //    rank[0] = 1;

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (scores[i] == scores[i - 1])
        //        {
        //            rank[i] = rank[i - 1];
        //        }
        //        else
        //        {
        //            rank[i] = rank[i - 1] + 1;
        //        }
        //    }

        //    for (int i = 0; i < m; i++)
        //    {
        //        int aliceScore = alice[i];
        //        if (aliceScore > scores[0])
        //        {
        //            res[i] = 1;
        //        }
        //        else if (aliceScore < scores[n - 1])
        //        {
        //            res[i] = rank[n - 1] + 1;
        //        }
        //        else
        //        {
        //            int index = binarySearch(scores, aliceScore);
        //            res[i] = rank[index];

        //        }
        //    }
        //    return res.ToList();

        //}

        //public static int binarySearch(int[] a, int key)
        //{

        //    int lo = 0;
        //    int hi = a.Length - 1;

        //    while (lo <= hi)
        //    {
        //        int mid = lo + (hi - lo) / 2;
        //        if (a[mid] == key)
        //        {
        //            return mid;
        //        }
        //        else if (a[mid] < key && key < a[mid - 1])
        //        {
        //            return mid;
        //        }
        //        else if (a[mid] > key && key >= a[mid + 1])
        //        {
        //            return mid + 1;
        //        }
        //        else if (a[mid] < key)
        //        {
        //            hi = mid - 1;
        //        }
        //        else if (a[mid] > key)
        //        {
        //            lo = mid + 1;
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region Working for 2 test case only.....
        //public static List<int> climbingLeaderboard()//List<int> ranked, List<int> player)
        //{
        //    List<int> objList = new List<int>();//remove this if not needed..

        //    List<int> ranked = new List<int>() { 100, 100, 50, 40, 40, 20, 10 };//This will be removed since this is already given..
        //    List<int> player = new List<int>() { 5, 25, 50, 120 };//This will be removed since this is already given..
        //    Dictionary<int, int> rankAndNumber = new Dictionary<int, int>();
        //    //Dictionary<int, int> playerWithRank = new Dictionary<int, int>();
        //    List<int> listRankedNumber = new List<int>();
        //    for (int i = 0; i<ranked.Count; i++)
        //    {
        //        try
        //        {
        //            rankAndNumber.Add(ranked[i], i+1);
        //        }
        //        catch
        //        { 
        //            //do nothing...
        //        }
        //        if (i == ranked.Count - 1)
        //        {
        //            rankAndNumber.Add(ranked[i] - 1, i + 1);
        //        }
        //    }
        //    for (int i = 0; i < rankAndNumber.Count; i++)
        //    {
        //        var varr = rankAndNumber.ElementAt(i);
        //        listRankedNumber.Add(varr.Key);
        //    }
        //    int k = listRankedNumber.Count, counter = 0;
        //    for (int i = 0; i < player.Count; i++)
        //    {
        //        while (k > 0)
        //        {
        //            //var numberRankPair = rankAndNumber.ElementAt(k);
        //            //int nextnumberRankPair = 0;
        //            //if (k > 1 && k < rankAndNumber.Count - 2) { nextnumberRankPair = rankAndNumber.FirstOrDefault(x => x.Key == k + 1).Value; }

        //            if (player[i] <= listRankedNumber[k-1] && counter == 0)
        //            {
        //                objList.Add(k);
        //                counter++;
        //                break;
        //            }
        //            else if (player[i] == listRankedNumber[k-1])//&& player[i] < nextnumberRankPair.Key)
        //            {
        //                objList.Add(k);
        //                counter++;
        //                break;
        //            }
        //            else if (player[i] >= listRankedNumber[k-1] && k>1)
        //            {
        //                if (player[i] < listRankedNumber[k - 2])
        //                {
        //                    objList.Add(k);
        //                    counter++;
        //                    break;
        //                }
        //            }
        //            else if (player[i] >= listRankedNumber[k - 1] && k ==1)
        //            {
        //                objList.Add(k);
        //                counter++;
        //                break;
        //            }

        //            //else if (player[i] >= listRankedNumber[k - 1] && )
        //            //{
        //            //    objList.Add(k + 1);
        //            //    counter++;
        //            //    break;
        //            //}
        //            k--;
        //        }
        //        k--;
        //    }
        //    return objList;

        //}
        #endregion

        #region -- climbing Leader Board 2 ... This method isn't working...
        //public static List<int> climbingLeaderboard2()//List<int> ranked, List<int> player)
        //{
        //    List<int> objList = new List<int>();//remove this if not needed..

        //    List<int> ranked = new List<int>() { 100, 90, 90, 80 };//This will be removed since this is already given..
        //    List<int> player = new List<int>() { 70, 80, 105 };//This will be removed since this is already given..
        //    Dictionary<int, int> rankAndNumber = new Dictionary<int, int>();
        //    Dictionary<int, int> playerWithRank = new Dictionary<int, int>();
        //    for (int i = 0; i < ranked.Count; i++)
        //    {
        //        try
        //        {
        //            rankAndNumber.Add(ranked[i], i+1);
        //        }
        //        catch
        //        { 
        //            //do nothing...
        //        }
        //        if (i == ranked.Count - 1)
        //        {
        //            rankAndNumber.Add(ranked[i]-1, i+1);
        //        }
        //    }
        //    int k = rankAndNumber.Count - 1, counter =0;
        //    for (int i = 0; i < player.Count; i++)
        //    {
        //        while (k > 0)
        //        {
        //            var numberRankPair = rankAndNumber.ElementAt(k);
        //            int nextnumberRankPair=0;
        //            if (k > 1 && k < rankAndNumber.Count - 2) { nextnumberRankPair = rankAndNumber.FirstOrDefault(x => x.Key == k+1).Value; }

        //            if (player[i] <= numberRankPair.Key && counter == 0)
        //            {
        //                objList.Add(numberRankPair.Value);
        //                counter++;
        //                break;
        //            }
        //            else if (player[i] == numberRankPair.Key )//&& player[i] < nextnumberRankPair.Key)
        //            {
        //                objList.Add(numberRankPair.Value);
        //                counter++;
        //                break;
        //            }
        //            else if (player[i] >= numberRankPair.Key && player[i] < nextnumberRankPair)
        //            {
        //                objList.Add(numberRankPair.Value);
        //                counter++;
        //                break;
        //            }

        //        }
        //        k--;
        //    }
        //    return objList;

        //}
        #endregion

        #region -- climbing Leader Board ... This method isn't working...
        //public static List<int> climbingLeaderboard1()//List<int> ranked, List<int> player)
        //{
        //    List<int> objList = new List<int>();
        //    List<int> ranked = new List<int>() { 100, 90, 90, 80};

        //    List<int> player = new List<int>() { 70, 80, 105};
        //    List<int> resultplayer = new List<int>();
        //    Dictionary<int, int> rankWithNumber = new Dictionary<int, int>();
        //    List<int> uniqueRank = new List<int>();
        //    int counter = 0, ranking =1, k =0;
        //    for (int i = 0; i < ranked.Count; i++)
        //    {
        //        if (counter == 0)
        //        {
        //            rankWithNumber.Add(ranking, ranked[i]);
        //            counter++;
        //            ranking++;
        //        }
        //        else
        //            if (ranked[i] == ranked[i - 1] && counter > 0)
        //        {
        //            //ranking--;

        //            //rankWithNumber.Add(ranking, ranked[i]);
        //            //ranking++;
        //        }
        //        else if (ranked[i] < ranked[i - 1] && counter > 0)
        //        {
        //            rankWithNumber.Add(ranking, ranked[i]);
        //            ranking++;
        //        }

        //    }
        //    for (int i = 0; i < rankWithNumber.Count; i++)
        //    {
        //        var val = rankWithNumber.ElementAt(i);
        //        //Console.WriteLine($"{val.Key}, {val.Value}");
        //        uniqueRank.Add(val.Value);
        //        if (i == rankWithNumber.Count - 1)
        //        {
        //            uniqueRank.Add(val.Value-1);
        //        }
        //    }
        //    counter = 0;
        //    k = uniqueRank.Count - 1;
        //    while (k >=0)
        //    {
        //        for (int j = 0; j < player.Count; j++)
        //        {
        //            if (player[j] <= uniqueRank[k] && counter == 0)
        //            {
        //                resultplayer.Add(uniqueRank[k]);
        //                Console.WriteLine($"Came here:{uniqueRank[k]}");
        //                counter++;
        //                break;
        //            }
        //            else if (player[j] >= uniqueRank[k] && counter > 0)
        //            {
        //                resultplayer.Add(uniqueRank[k]);
        //                Console.WriteLine($"Came here:{uniqueRank[k]}");
        //                counter++;
        //                break;
        //            }
        //        }
        //        k--;
        //    }
        //    return objList;
        //}
        #endregion

    }
}

