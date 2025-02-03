namespace L250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int i = 5;

            // 후위 증가 연산자 예제 (i++)
            Console.WriteLine("후위 증가 연산자 (i++):");
            Console.WriteLine("i의 현재 값: " + i);          // 5 출력
            Console.WriteLine("i++를 실행한 결과: " + i++);    // 현재 x의 값(5)을 출력한 후 x를 1 증가시킴
            Console.WriteLine("i++ 실행 후 i의 값: " + i);    // 증가 후 x는 6

            Console.WriteLine();  // 빈 줄 출력

            // 전위 증가 연산자 예제 (++i)
            i = 5;  // x 값을 다시 5로 초기화
            Console.WriteLine("전위 증가 연산자 (++i):");
            Console.WriteLine("i의 현재 값: " + i);          // 5 출력
            Console.WriteLine("++i를 실행한 결과: " + ++i);    // 먼저 x를 1 증가시킨 후 증가된 값(6)을 출력
            Console.WriteLine("++i 실행 후 i의 값: " + i);    // x는 이미 6
            // Hello github
        }
    }
}
