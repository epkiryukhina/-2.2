using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2._2
{
    class Program
    {
        public static void Output(List<int> result)
        {
            int i;

            for (i = 0; i < result.Count; i++)
                if (result[i] != 0) break;

            for (int j = i; j < result.Count; j++)
                Console.Write(result[j]);
        }

        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            List<int> result = new List<int>();
            string max = first;
            string min = "";

            for (int i = 0; i < first.Length; i++)
            {
                first = first.Substring(1) + first[0];
                if (string.Compare(first, max) == 1)
                    max = first;
            }

            for (int i = 0; i < second.Length; i++)
            {
                second = second.Substring(1) + second[0];
                if (second[0].ToString() != "0")
                {
                    if (min == "")
                        min = second;
                    else if (string.Compare(min, second) == 1)
                        min = second;
                }
            }

            //Console.WriteLine(max);
            //Console.WriteLine(min);

            if (max.Length > min.Length)
            {
                for (int i = 1; i <= min.Length; i++)
                    result.Add(Int32.Parse(max[max.Length - i].ToString()) - Int32.Parse(min[min.Length - i].ToString()));

                for (int i = max.Length - min.Length - 1; i >= 0; i--)
                    result.Add(Int32.Parse(max[i].ToString()));

                result.Reverse();

                for (int i = result.Count - 1; i >= 0; i--)
                    if (result[i] < 0)
                    {
                        result[i] = result[i] + 10;
                        result[i - 1] = result[i - 1] - 1;
                    }

                Output(result);
            }
            else if (max.Length == min.Length)
            {
                if (string.Compare(max, min) == 1)
                {
                    for (int i = 1; i <= max.Length; i++)
                        result.Add(Int32.Parse(max[max.Length - i].ToString()) - Int32.Parse(min[min.Length - i].ToString()));

                    result.Reverse();

                    for (int i = result.Count - 1; i > 0; i--)
                        if (result[i] < 0)
                        {
                            result[i] = result[i] + 10;
                            result[i - 1] = result[i - 1] - 1;
                        }
                }
                else if (string.Compare(max, min) == -1)
                {
                    for (int i = 1; i <= max.Length; i++)
                        result.Add(Int32.Parse(min[min.Length - i].ToString()) - Int32.Parse(max[max.Length - i].ToString()));

                    result.Reverse();

                    for (int i = result.Count - 1; i > 0; i--)
                        if (result[i] < 0)
                        {
                            result[i] = result[i] + 10;
                            result[i - 1] = result[i - 1] - 1;
                        }

                    Console.Write("-");
                }
                else
                    Console.Write("0");

                Output(result);
            }
            else if (max.Length < min.Length)
            {
                for (int i = 1; i <= max.Length; i++)
                    result.Add(Int32.Parse(min[min.Length - i].ToString()) - Int32.Parse(max[max.Length - i].ToString()));

                for (int i = min.Length - max.Length - 1; i >= 0; i--)
                    result.Add(Int32.Parse(min[i].ToString()));

                result.Reverse();

                for (int i = result.Count - 1; i >= 0; i--)
                    if (result[i] < 0)
                    {
                        result[i] = result[i] + 10;
                        result[i - 1] = result[i - 1] - 1;
                    }

                result[0] = result[0] * (-1);

                Output(result);
            }

            Console.ReadLine();
        }
    }
}
