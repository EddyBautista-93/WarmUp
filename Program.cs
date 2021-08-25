using System;
using System.Collections.Generic; // add to use List 


namespace WarmUp
{
    class Program
    {
        // Q1. Sales by Match
        // There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

        // Example

        // There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .

        // Function Description

        // Complete the sockMerchant function in the editor below.

        // sockMerchant has the following parameter(s):

        // int n: the number of socks in the pile
        // int ar[n]: the colors of each sock

        // solving the question before coding 

        // notes -
        // The Main goal is to find matching pairs so the things i know for sure is that
        // -- I will want to loop through the list int ar
        // -- I will be using int n as the length 
        // -- use hashset

        public static int sockMerchant(int n, List<int> ar)
        {
            int pairs = 0;
            // create a empty hashset to store unmatched 
            HashSet<int> unMatched = new HashSet<int>();


            for (var i = 0; i < n; i++)
            {
                // We check to see if the int exist in the hashset.
                // The first instance will be added since the list is empty and if we
                // come accross the number again we can remove the same number from the hashset
                // and increment the pairs variable. 
                if (unMatched.Contains(ar[i]))
                {
                    pairs++;
                    unMatched.Remove(ar[i]);
                }
                else
                {
                    unMatched.Add(ar[i]);
                }
            }
            return pairs;
        }


        //Q2.Counting Valleys 
        // An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly  steps, for every step it was noted if it was an uphill, , or a downhill,  step. Hikes always start and end at sea level, and each step up or down represents a  unit change in altitude. We define the following terms:

        // A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
        // A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
        // Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.

        // Example



        // The hiker first enters a valley  units deep. Then they climb out and up onto a mountain  units high. Finally, the hiker returns to sea level and ends the hike.

        // Function Description

        // Complete the countingValleys function in the editor below.

        // countingValleys has the following parameter(s):

        // int steps: the number of steps on the hike
        // string path: a string describing the path
        // Returns

        // int: the number of valleys traversed
        // Input Format

        // The first line contains an integer , the number of steps in the hike.
        // The second line contains a single string , of  characters that describe the path.

        // Constraints

        // Sample Input

        // 8
        // UDDDUDUU
        // Sample Output

        // 1
        // Explanation

        // If we represent _ as sea level, a step up as /, and a step down as \, the hike can be drawn as:

        // _/\      _
        //    \    /
        //     \/\/
        // The hiker enters and leaves one valley.

        public static int countingValleys(int steps, string path)
        {
            int stepCounter = 0;
            int valley = 0;
            // Break down the string anf use the U & D and ++ / --
            char[] pathCharArray = path.ToCharArray();
            for (var i = 0; i < steps; i++)
            {
                //we check to see if the hiker leaves the valley , by definition from the question - a hiker leaves the valley when they come back from below sea level. 
                if (stepCounter == -1 && pathCharArray[i] == 'U')
                {
                    ++valley;
                }
                // if uphill/ U = ++ , else --
                stepCounter = pathCharArray[i] == 'U' ? ++stepCounter : --stepCounter;
            }
            return valley;
        }

        // Q3.Jumping Clouds 

        // There is a new mobile game that starts with consecutively numbered clouds. Some of the clouds are thunderheads and 
        // others are cumulus. The player can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus 
        //  or . The player must avoid the thunderheads. Determine the minimum number of jumps it will take to jump from the starting postion 
        //  to the last cloud. It is always possible to win the game.

        public static int jumpingOnClouds(List<int> c)
        {
            int jumps = 0;
            int listLength = c.Count;

            for (var i = 0; i < listLength; i++)
            {
                if (i + 1 < listLength)
                {
                    if (i + 2 < listLength && c[i + 1] == 0 && c[i + 2] == 0)
                    {
                        jumps += 1;
                        i += 1;
                    }

                    else if (c[i + 1] == 0) jumps += 1;
                    else if (c[i + 1] == 1)
                    {
                        jumps += 1;
                        i += 1;
                    }
                }
            }
            return jumps;
        }

        // Q.4 Repeating String
        //         There is a string, , of lowercase English letters that is repeated infinitely many times. Given an integer, , find and print the number of letter a's in the first  letters of the infinite string.

        // Example


        // The substring we consider is , the first  characters of the infinite string. There are  occurrences of a in the substring.

        // Function Description

        

        // repeatedString has the following parameter(s):

        // s: a string to repeat
        // n: the number of characters to consider
        // Returns

        // int: the frequency of a in the substring
        // Input Format

        // The first line contains a single string, .
        // The second line contains an integer, .

        // Constraints

        // For  of the test cases, .
        // Sample Input

        // Sample Input 0

        // aba
        // 10
        // Sample Output 0

        // 7
        // Explanation 0
        // The first  letters of the infinite string are abaabaabaa. Because there are  a's, we return .

        public static long repeatedString(string s, long n)
        {
            int frequencyOfA = 0;

            return frequencyOfA;

        }

        static void Main(string[] args)
        {
            //SockMerchant 
            // int testLength = 7;
            // List<int> testList = new List<int>(){1, 2, 1, 2, 1, 3, 2};
            // sockMerchant(testLength, testList);

            //Counting Valleys
            // int testSteps = 12;
            // string testPath = "DDUUDDUDUUUD";
            // countingValleys(testSteps, testPath);

            //Jumping Clouds 
            // List<int> testList = new List<int> { 0, 1, 0, 0, 0, 1, 0 };
            // jumpingOnClouds(testList);

            //Repeated string 
            string testString = "aba";
            long testNum = 7;
            repeatedString(testString, testNum);
        }
    }
}
