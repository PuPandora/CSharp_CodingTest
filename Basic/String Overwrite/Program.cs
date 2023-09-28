using System;

// https://school.programmers.co.kr/learn/courses/30/lessons/181943
// 문제 설명
// 문자열 my_string, overwrite_string과 정수 s가 주어집니다.
// 문자열 my_string의 인덱스 s부터 overwrite_string의 길이만큼을 문자열 overwrite_string으로 바꾼 문자열을 return 하는 solution 함수를 작성해 주세요.

namespace String_Overwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("He11oWor1d", "lloWorl", 2));
        }

        public static string solution(string my_string, string overwrite_string, int s)
        {

            string answer = "";
            char[] my_char = my_string.ToCharArray();

            for (int i = 0; i < s; i++)
            {
                answer += my_char[i];
            }

            foreach (char c in overwrite_string)
            {
                answer += c;
            }

            if (my_string.Length > overwrite_string.Length + s)
            {
                for (int i = overwrite_string.Length + s; i < my_string.Length; i++)
                {
                    answer += my_char[i];
                }
            }

            return answer;
        }
    }
}
