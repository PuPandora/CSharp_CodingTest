using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 분수의 덧셈
// https://school.programmers.co.kr/learn/courses/30/lessons/120808#

// 문제 설명
// 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1,
// 두 번째 분수의 분자와 분모를 뜻하는 numer2, denom2가 매개변수로 주어집니다.
// 두 분수를 더한 값을 기약 분수로 나타냈을 때
// 분자와 분모를 순서대로 담은 배열을 return 하도록
// solution 함수를 완성해보세요.

namespace Adding_fractions
{
    public class Solution
    {
        public int[] solution(int numer1, int denom1, int numer2, int denom2)
        {
            int[] answer = new int[2];

            // 통분
            // 분자
            int firstTop = numer1 * denom2;
            int secondTop = numer2 * denom1;
            int topNum = firstTop + secondTop;
            // 분모
            int botNum = denom1 * denom2;

            // 약분
            int _gcd = GetGCD(topNum, botNum);
            answer[0] = topNum / _gcd;
            answer[1] = botNum / _gcd;

            return answer;
        }

        public int GetGCD(int a, int b)
        {
            if (b == 0)
                return a;

            return GetGCD(b, a % b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            // 1/2 + 3/4
            int[] a = solution.solution(1, 2, 3, 4);
            int[] b = solution.solution(9, 1, 2, 3);
            int[] c = solution.solution(997, 997, 997, 997);

            PrintSolution(a);
            PrintSolution(b);
            PrintSolution(c);

        }

        static void PrintSolution(int[] intArr)
        {
            foreach (int i in intArr)
                Console.WriteLine(i);
        }
    }
}
