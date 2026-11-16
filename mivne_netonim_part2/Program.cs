namespace mivne_netonim_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //targil1();
            //targil2();
            targil3();
        }
    
        static void targil1()
        {
            
            //Console.WriteLine("Enter a N");
            //int n = int.Parse(Console.ReadLine());
            int[] original = new int[] {1,2,3,4,5,-5,-9,-10};
            int[] negativ = new int[original.Length];
            int[] even = new int[original.Length];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter a number");
            //    original[i] = int.Parse(Console.ReadLine());
            //}
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] < 0)
                {
                    negativ[i] = original[i];
                }
                else if(original[i] % 2 == 0)
                {
                    even[i] = original[i];
                }
            }
            Console.WriteLine("Negative numbers:");
            for (int i = 0; i < negativ.Length; i++)
            {
                if (negativ[i] != 0)
                {
                    Console.Write(negativ[i]);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < even.Length; i++)
            {
                if (even[i] != 0)
                {
                    Console.Write(even[i]);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("All numbers:");
            for(int i = 0; i < original.Length; i++)
            {
                if (original[i] != 0)
                {
                    Console.Write(original[i]);
                    Console.Write(" ");
                }  
            }

        }
    
    

        static void targil2()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = new int[] { 9, 10, 11, 12 };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr3.Length; i++)
            {
                if (i < arr1.Length)
                {
                    arr3[i] = arr1[i];
                }
                else
                {
                    arr3[i] = arr2[i - arr1.Length];
                }
            }
            Console.WriteLine("Merged array:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]);
                Console.Write(" ");
            }
        }

        static void targil3()
        {

            //Console.WriteLine("Enter a N");
            //int n = int.Parse(Console.ReadLine());
            int[] original = new int[] { 114, 223, 200, 133, 233, 255, 112, 125 };
            int[] femaly1 = new int[original.Length];
            int[] femaly2 = new int[original.Length];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter a number");
            //    original[i] = int.Parse(Console.ReadLine());
            //}
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] / 100 == 1)
                {
                    femaly1[i] = original[i];
                }
                else if (original[i] / 100 == 2)
                {
                    femaly2[i] = original[i];
                }
            }
            Console.WriteLine("Family 1 flawers:");
            for (int i = 0; i < femaly1.Length; i++)
            {
                if (femaly1[i] != 0)
                {
                    Console.Write(femaly1[i]);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Family 2 flawers:");
            for (int i = 0; i < femaly2.Length; i++)
            {
                if (femaly2[i] != 0)
                {
                    Console.Write(femaly2[i]);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("All flowers:");
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] != 0)
                {
                    Console.Write(original[i]);
                    Console.Write(" ");
                }
            }
        }
    
    
    
    }
}
