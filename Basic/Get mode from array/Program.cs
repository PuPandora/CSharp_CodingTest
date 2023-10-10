using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 최빈값 구하기
// 문제 설명
// 최빈값은 주어진 값 중에서 가장 자주 나오는 값을 의미합니다.
// 정수 배열 array가 매개변수로 주어질 때,
// 최빈값을 return 하도록 solution 함수를 완성해보세요.
// 최빈값이 여러 개면 -1을 return 합니다.

namespace Get_mode_from_array
{
    public class Solution
    {
        public int solution(int[] array)
        {
            int answer = 0;
            int[] storage = new int [1000];

            // 최빈값
            int mode = int.MinValue;
            // 최빈값 인덱스
            int modeIndex = int.MinValue;
            // 최빈값 중복 여부 (n > 1)
            int modeCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                storage[array[i]]++;
            }

            // 최빈값 탐색
            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i] > mode)
                {
                    mode = storage[i];
                    modeIndex = i;
                }
            }

            // 중복 최빈값 탐색
            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i] == mode)
                    modeCount++;
            }

            if (modeCount >= 2)
                answer = -1;
            else
                answer = modeIndex;

            return answer;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //Console.WriteLine(solution.solution(new int[] { 1, 1, 1 }));
            //Console.WriteLine(solution.solution(new int[] { 1, 2, 3 }));
            //Console.WriteLine(solution.solution(new int[] { 1 }));
            Console.WriteLine(solution.solution(new int[] { 0 }));
            Console.WriteLine(solution.solution(new int[] { 0, 0, 1, 1 }));
            //Console.WriteLine(solution.solution(new int[] { 0, 1, 2, 2, 3 }));
            //Console.WriteLine(solution.solution(new int[] { 1, 1, 2, 2, 3 }));
            //Console.WriteLine(solution.solution(new int[] { 1, 2, 2, 3, 3 }));
            //Console.WriteLine(solution.solution(new int[] { 1, 1, 2, 2, 3, 3 }));
            //Console.WriteLine(solution.solution(new int[] { 1, 2, 3, 3, 3, 4 }));
            //Console.WriteLine(solution.solution(new int[] { 1, 3, 1, 3, 2, 2, 3, 3 }));
        }
    }
}
