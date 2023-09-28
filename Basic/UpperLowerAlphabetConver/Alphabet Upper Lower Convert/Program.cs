using System;

// https://school.programmers.co.kr/learn/courses/30/lessons/181949?language=csharp
// 문제 설명
// 영어 알파벳으로 이루어진 문자열 str이 주어집니다.
// 각 알파벳을 대문자는 소문자로 소문자는 대문자로 변환해서 출력하는 코드를 작성해 보세요.

namespace Alphabet_Upper_Lower_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = AlphabetsUpperLowerConvert(s);
            Console.WriteLine(result);
        }

        static string AlphabetsUpperLowerConvert(string s)
        {
            char[] cArr = s.ToCharArray();
            string result = "";

            for (int i = 0; i < cArr.Length; i++)
            {
                if (char.IsUpper(cArr[i]))
                    result += cArr[i].ToString().ToLower();
                else if (char.IsLower(cArr[i]))
                    result += cArr[i].ToString().ToUpper();
            }

            return result;
        }
    }
}
