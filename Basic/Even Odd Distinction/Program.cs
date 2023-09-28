using System;

// https://school.programmers.co.kr/learn/courses/30/lessons/181944
// 문제 설명
// 자연수 n이 입력으로 주어졌을 때 만약 n이 짝수이면 "n is even"을,
// 홀수이면 "n is odd"를 출력하는 코드를 작성해 보세요.

namespace Even_Odd_Distinction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s;

            s = Console.ReadLine();
            int num = Int32.Parse(s);

            if (CheckEven(num))
                Console.WriteLine(num + " is even");
            else
                Console.WriteLine(num + " is odd");
        }

        static bool CheckEven(int num)
        {
            switch (num % 2)
            {
                case 0:
                    return true;
                case 1:
                    return false;

                default:
                    Console.WriteLine("Default");
                    return false;
            }
        }
    }
}
