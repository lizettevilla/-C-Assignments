﻿         //1. Iterate and print values - Given a List of strings, iterate through the List and print out all the values.
        static void PrintList(List<string> MyList)

            // your code here
            for (int i = 0; i < MyList.Count; i++)
        {
            Console.WriteLine(MyList[i]);
        }

        List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
        PrintList(TestStringList);



        //2. Print Sum - Given a List of integers, calculate and print the sum of the values.
        static void SumOfNumbers(List<int> IntList)
        {
            // Your code here
            int sum = 0;
            for (int i = 0; IntList.Count; i++)
            {
                sum += IntList[i];
            }
            Console.WriteLine(sum);
        }
        List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
        // You should get back 33 in this example
        SumOfNumbers(TestIntList);



        // 3. Find Max - Given a List of integers, find and return the largest value in the List.
        static int FindMax(List<int> IntList)
        {
            // Your code here
            int maxValue = IntList.Max();
            Console.WriteLine(maxValue);
            return maxValue;
        }
        List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
        // You should get back 17 in this example
        FindMax(TestIntList2);


        //4. Square the Values - Given a List of integers, return the List with all the values squared.
        static List<int> SquareValues(List<int> IntList)
        {
            // Your code here
            for (int i = 0; i < IntList.Count; i++) ;
            {
                IntList[i] = IntList[i] * IntList[i];
            }
            return IntList;
        }
        List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
        // You should get back [1,4,9,16,25], think about how you will show that this worked
        SquareValues(TestIntList3);


        // 5. Replace Negative Numbers with 0 - Given an array of integers, return the array with all values below 0 replaced with 0.
        static int[] NonNegatives(int[] IntArray)
            // Your code here
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (IntArray[i] < 0)
                {
                    IntArray[i] = 0;
                }
            }
            int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
            // You should get back [0,2,3,0,5], think about how you will show that this worked
            NonNegatives(TestIntArray);


            // 6. Print Dictionary - Given a dictionary, print the contents of the said dictionary.
            static void PrintDictionary(Dictionary<string, string> MyDictionary)
            {
                // Your code here
                foreach (KeyValuePair<string, string> entry in MyDictionary)
                {
                    Console.WriteLine($"{entry.Key} - {entry.Value}");
                }
            }
            Dictionary<string, string> TestDict = new Dictionary<string, string>();
            TestDict.Add("HeroName", "Iron Man");
            TestDict.Add("RealName", "Tony Stark");
            TestDict.Add("Powers", "Money and intelligence");
            PrintDictionary(TestDict);


            // 7. Find Key - Given a search term, return true or false whether the given term is a key in a dictionary.
            static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
            {
                // Your code here
            }
            // Use the TestDict from the earlier example or make your own
            // This should print true
            // This should print false


            /* 8. Generate a Dictionary - Given a List of names and a List of integers, create a 
            dictionary where the key is a name from the List of names and the value is a number 
            from the List of numbers. Assume that the two Lists will be of the same length. 
            Don't forget to print your results to make sure it worked. */
            // Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
            // {
            //	"Julie": 6,
            //	"Harold": 12,
            //	"James": 7,
            //	"Monica": 10
            // } 
            static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
                // Your code here
            
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here