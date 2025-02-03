using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.VisualBasic;

namespace L250123_Practice
{
    internal class Program
    {
        static void Main(string[] args)  // entry point , 실행시 처음 수행되는곳
        {
            Class1.helloworld();
            //Console.WriteLine("Hello, World!"); // 콘솔 : 기본 입출력장치 writeline : 한줄 출력
            // f9 코드 앞에 누르면 붉은색으로 바뀌면서 그전까지만 실행되고 디버깅 가능?
            //Console.WriteLine(1 + 1);
            //int x = 256, y = 512;
            //Console.WriteLine(x);

            double z;
            z = 100;
            // string N = Console.ReadLine();
            // z = int.Parse(N);
            Console.WriteLine(z);

            byte a = 10; // 1byte 공간할당
            Console.WriteLine(a);
            char b = 'A';
            Console.WriteLine(b);
            string c = "JUN";
            Console.WriteLine(c);
            Debug.WriteLine("debug");

            var scores = new Dictionary<string, int>
            {
                { "Korean", 85 },
                { "English", 92 },
                { "Math", 78 }
            };

            double average = scores.Values.Average(); // 점수(Value)들의 평균 계산
            Console.WriteLine($"딕셔너리 사용 - 평균: {average:F2}");

            // 혹은



            float sum = 0; // 합계 변수
            float average2 = 0; // 평균 변수

            foreach (var value in scores.Values)
            {
                sum += value; // value는 int 타입이지만 float에 자동 변환됨
            }

            average2 = sum / 3.0f; // 총합을 3.0f로 나눠 평균 계산
            Console.WriteLine($"총합: {sum}, 평균: {average2:F2}");

            // string.Join
            Console.WriteLine(string.Join(", ", scores.Values)); // 출력: 85, 92, 78

            // key value 동시 출력
            foreach (var kvp in scores)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}"); // Korean: 85, English: 92, Math: 78
            }



            // 배열 & 반복문
            int[] koreans = new int[10];
            Console.WriteLine(koreans.Length);

            for (int i = 0; i < koreans.Length; i++)
            {
                koreans[i] = 1;
                Console.WriteLine($"koreans[{i}] = " + koreans[i]);
            }
            

            byte _1;
            short _2;
            uint _3;
            BigInteger _4;
            Console.WriteLine("정수를 입력하세요:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"입력한 숫자는: {number}");
            }
            else
            {
                Console.WriteLine("유효한 정수를 입력하세요.");
            }


            if (number % 2 == 1)
            {
                Console.WriteLine("odd");

            }
            else
            {
                Console.WriteLine("even");
            }



            // 4의 배수 검출하기
            // 4로 나눠서 나머지가 0인 정수들
            string N = Console.ReadLine();
            int num = int.Parse(N);

            if (num != 0 && num % 4 == 0)
            {
                Console.WriteLine("4의 배수");
            }
            else
            {
                Console.WriteLine("4의 배수 아님");
            }

            int size = 20;
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            //Console.WriteLine(i);
            char wall = '*';
            for (int i = 0; i < 5; i++)
            {
                Console.Write(wall);
            }

            // 1에서 백까지 더하기
            int[] numbers100 = new int[100];
            int sum1 = 0;
            for (int i = 0; i < numbers100.Length ; i++)
            {
                numbers100[i] = i + 1;
                sum1 += numbers100[i];
            }
            Console.WriteLine($"1부터100까지의합은 : {sum1}");

            // 짝수, 홀수만 더하기
            int sum2=0, sum3 = 0;
            for (int i = 0; i < numbers100.Length; i++)
            {
                if (numbers100[i] % 2 == 0)
                {
                    sum2 += numbers100[i];
                }
                else
                {
                    sum3 += numbers100[i];
                }
            }

            Console.WriteLine($"1부터100까지의 짝수의 합은 : {sum2}");
            Console.WriteLine($"1부터100까지의 홀수의 합은 : {sum3}");



            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i 값 출력하기 : {i}");
            }
        }
    }
}

//oop 객체지향프로그래밍은 class로 구현한다.
//program class 아래 형태는 외워두자
// build compile 실행(디버그?) 순서로 진행

//Ctrl + k -> 정렬