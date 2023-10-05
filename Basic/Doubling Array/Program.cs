using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열 두배 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/120809

// 문제 설명
// 정수 배열 numbers가 매개변수로 주어집니다.
// numbers의 각 원소에 두배한 원소를 가진 배열을
// return하도록 solution 함수를 완성해주세요.

namespace Doubling_Array
{
    public class Solution
    {
        //public int[] solution(int[] numbers)
        //{
        //    int[] answer = new int[numbers.Length];
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        answer[i] = numbers[i] * 2;
        //    }

        //    return answer;
        //}

        public int[] solution(int[] numbers)
        {
            int[] intArr = numbers;

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] *= 2;
            }
            return intArr;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] Arr = new int[] { 1, 20, 40, 21, 42, 96, 67, 23};

            foreach (int i in solution.solution(Arr))
            {
                Console.WriteLine(i);
            }
        }
    }
}
