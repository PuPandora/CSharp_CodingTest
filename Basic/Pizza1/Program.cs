using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://school.programmers.co.kr/learn/courses/30/lessons/120814
머쓱이네 피자가게는 피자를 일곱 조각으로 잘라 줍니다.
피자를 나눠먹을 사람의 수 n이 주어질 때,
모든 사람이 피자를 한 조각 이상 먹기 위해
필요한 피자의 수를 return 하는 solution 함수를 완성해보세요.
 */

namespace Pizza1
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer;
            const int pizzaPiece = 7;

            if (n % pizzaPiece == 0)
            {
                answer = n / pizzaPiece;
            }
            else
            {
                // int로 형변환 될 때 소수 전부를 버리는 것을 이용한 +1
                answer = n / pizzaPiece + 1;
            }

            return answer;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(15));
            // Math.Ceiling 내림 나누기를 하면 쉽게 구할 수 있었다!
        }
    }
}
