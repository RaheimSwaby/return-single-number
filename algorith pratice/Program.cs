using System.Globalization;

namespace algorith_pratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3,1,3,7 };
           Duplicate(array);
        }



        public static void Duplicate(int[] array)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int num in array)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else
                {
                    map[num] = 1;
                }
            }
            Console.WriteLine("non duplicate elements");
            foreach (var entry in map)
            {
                if (entry.Value == 1)
                {
                    Console.WriteLine(entry.Key);
                }

            }
            //if (array.Length < 2)
            //{
            //    throw new ArgumentException("Array must have at least two elements to find duplicates.");
            //}

            
            //Array.Sort(array); 

           
            //for (int i = 0; i < array.Length - 1; i++) // O(n)
            //{
            //    if (array[i] != array[i + 1])
            //    {
            //        return array[i];
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}
           //return array[array.Length -1 ]; // No duplicates found
           
            //    HashSet<int> set = new HashSet<int>();
            //    foreach (int i in array) 
            //    {
            //        if (set.Contains(i)) 
            //        {
            //            set.Remove(i);
            //        }
            //        else 
            //        {
            //            set.Add(i);
            //        }   
            //    }
            //    return set.First();
            //}
        }

        }
}
