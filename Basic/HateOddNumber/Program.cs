using System;
using System.Collections.Generic;

/*
https://school.programmers.co.kr/learn/courses/30/lessons/120813?language=csharp
짝수는 싫어요
정수 n이 매개변수로 주어질 때,
n 이하의 홀수가 오름차순으로 담긴 배열을 return하도록
solution 함수를 완성해주세요.
*/

namespace HateOddNumber
{
    public class Solution
    {
        // 첫 번째 풀이
        // 리스트 사용
        // 배열 생성 상수 값만 받길래 리스트를 사용
        public int[] solution(int n)
        {
            int[] answer;
            List<int> intList = new List<int>();
            
            for (int i = 1; i <= n; i += 2)
            {
                intList.Add(i);
            }
            answer = intList.ToArray();

            return answer;
        }

        // 두 번째 풀이
        // 다른 문제 풀이 보니 연산한 값이 들어간다...
        public int[] solution2(int n)
        {
            // n이 짝수면 n/2 크기 배열, 홀수면 n/2+1 크기 배열
            int[] answer = new int[(n % 2 == 0 ? n / 2 : n / 2 + 1)];

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = i * 2 + 1;
            }

            return answer;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] a = s.solution(15);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{i}. {a[i]}");
            }

            int[] b = s.solution2(15);
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"{i}. {a[i]}");
            }
        }
    }
}
