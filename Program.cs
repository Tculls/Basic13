namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sample = {2,10,3};
            int[] sampleAllNegative = { -5, -2, -6 };
            int[] shiftingExample = { 1, 5, 10, 7, 2};
            int[] sampleNumTOString = { -1, 13, 2};
            static void PrintNumbers()
            {
                // Print all of the integers from 1 to 255.
                for(int i=0; i<255; i++)
                {
                Console.WriteLine(i);
                }   
            }
            PrintNumbers();

            static void PrintOdds()
            {
                // Print all of the odd integers from 1 to 255.
                for(int i=0; i<255; i++)
                {
                    if(i%2 !=0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            PrintOdds();

            static void PrintSum()
            {
                // Print all of the numbers from 0 to 255, and print the sum ass you go
                int i = 0;
                int sum = 0;
                while (i<256)
                
                {
                    sum+= i;
                    Console.WriteLine($"New Number: {i}  Sum: {sum}");
                    i++;
                }
            }
            PrintSum();

            static void LoopArray(int[] numbers)
            {
                // Write a function that would iterate through each item of the given integer array and print each value  to the console.
                {
                    for (int i=0; i<numbers.Length; i++)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
            }
            LoopArray(samples);

            static int FindMax(int[] numbers)
            {
                int max = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                        max = numbers[i];
                }
                return (max);
            }
            FindMax(sampleAllNegative);

            static void GetAverage(int[] numbers)
            {
                int sum = 0;
                for (int i = 0; i < numbers.length; i++)
                {
                    sum += numbers[i];
                }
                int avg = sum / numbers.length;
                Console.WriteLine(avg);
            }
            GetAverage(samples);

            static int[] OddArray()
            {
                int[] allOdds = new int[256/2];
                for (int i = 1; i<=255; i+=2)
                {
                    allOdds[i/2] = i;
                }
                return (allOdds);
            }
            OddArray();

            static int GreaterThanY(int[] numbers, int y)
            {
                int indexTally=0;
                foreach (int num in numbers)
                {
                    if (num > y)
                        indexTally++;
                }
                return indexTally;
            }
            GreaterThanY(samples,3);

            static void SquareArryValues(int[] numbers)
            {
                for (int i=0; i<number.Length; i++)
                {
                    numbers[i] = numbers[i] * numbers [i];
                }
            }
            SquareArryValues(samples);
            SquareArryValues(sampleAllNegative);

            static void EliminateNegatives(int[] numbers)
            {
                for (int i = 0; i < numbers.length; i++)
                {
                    if (numbers[i] <0)
                    numbers[i] = 0;
                    else
                        numbers[i] = numbers[i];
                }
            }
            EliminateNegatives(sampleAllNegative);

            static void MinMaxArverage(int[] numbers)
            {
                int max = numbers[0];
                int min = numbers[0];

                for (int i = 0; i < numbers.Length; i++0);
                {
                    if (numbers[i] > max)
                        max = numbers[i];
                }

                int avg = (min + max) / 2;
            }
            MinMaxArverage(samples);
            MinMaxArverage(sampleAllNegative);


            static void ShiftValues(int[] numbers)
            {
                for ( int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }
                numbers[numbers.Length - 1] = 0;
            }
            ShiftValues(shiftingExample);
        } 
        static object[] NumToString(int[] numbers)
        {
            object[] objects = new object[numbers.Length];
            for (int i = 0 ; i< numbers.Length; i ++)
            {
                if (numbers[i] <0 )
                objects[i] = "Dojo";
                else
                objects[i] = numbers[i];
            }
            return objects;
        }
        NumToString(sampleAllNegative);
    }
}

        