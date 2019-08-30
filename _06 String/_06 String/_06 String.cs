using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             쉽게 설명하면, 문자열 String 은 문자 char 의 배열이다. (...)

            C#의 키워드 string은 .NET의 System.String 클래스와 동일하며, 따라서 System.String 클래스의 모든 메서드와 속성(Property)을 사용할 수 있다.
            예를 들어 일정 문자열 부분만 뽑아내는 Substring() 메서드, 문자열 길이를 구하는 Length 속성 등을 모두 사용할 수 있다. (좀더 알아볼 예정.)

            C# 문자열은 한번 문자열이 설정되면, 다시 변경할 수 없다. 
            (주: 한번 그 값이 설정되면 다시 변경할 수 없는 타입을 Immutable Type이라 부르고, 반대로 값을 계속 변경할 수 있는 것을 Mutable Type이라 부른다) 
            예를 들어, 문자열 변수 s 가 있을 때, s = "C#"; 이라고 한 후 다시 s = "F#"; 이라고 실행하면, (참.. 예제가..)
            .NET 시스템은 새로운 string 객체를 생성하여 "F#"이라는 데이타로 초기화 한 후 이를 변수명 s 에 할당한다. 
            즉, 변수 s 는 내부적으로는 전혀 다른 메모리를 갖는 객체를 가리키는 것이다.
             */

            // 문자열(string) 변수
            string s1 = "C#";
            string s2 = "Programming";

            // 문자(char) 변수 
            char c1 = 'A';
            char c2 = 'B';

            // 문자열 결합
            string s3 = s1 + " " + s2; // s3 라는 문자열을 새롭게 만들어, s1 에 " "를 더한 다음에 s2를 더해, s3가 "c# Programming" 이 되도록 함.
            Console.WriteLine("String: {0}", s3); // 적게 함.

            // 부분문자열
            string s4 = s3.Substring(1, 5); // 새로 만들어지는 s4 문자열은 s2의 substring의 1에서 5까지니까, "rogr" 이다.
            Console.WriteLine("Substring: {0}", s4);

            string s = "C# Studies";

            // 문자열 치환 (교환)

            string s5 = s2.Replace("pro", "PRO"); // 치환됨. 사실 다른 방식도 존재함.  

            // 문자열 삭제

            string s6 = s2.Remove(3);// Pro가 

            // 공백 삭제

            string s7 = "Hello     ".Trim(); // "" 뒤에 함수를 붙힐수도 있다!





            // 문자열을 배열인덱스로 한문자 엑세스 
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, s[i]);
            }

            // 문자열을 문자배열로 변환
            string str = "Hello";
            char[] charArray = str.ToCharArray(); // str.ToCHarArray는 상당히 쓸만한것 같다. 기억.(이런 형태의 To~~가 있는지도 확인)

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            // 문자배열을 문자열로 변환
            char[] charArray2 = { 'A', 'B', 'C', 'D' };
            s = new string(charArray2);

            Console.WriteLine(s);

            // 문자 연산
            char c_c1 = 'A';
            char c_c2 = (char)(c1 + 3);
            Console.WriteLine(c2);  // D 출력

            /*
             문자열을 다루는데 중요한 클래스 중의 하나는 System.Text.StringBuilder 클래스이다. 
             String 클래스는 위에서 설명한 대로 Immutable이기 때문에, 문자열 갱신을 많이 하는 프로그램에는 적당하지 않다. 
             반면 Mutable 타입인 StringBuilder 클래스는 문자열 갱신이 많은 곳에서 자주 사용되는데 이는 이 클래스가 별도 메모리를 생성,
             소멸하지 않고 일정한 버퍼를 갖고 문자열 갱신을 효율적으로 처리하기 때문이다.

             특히 루프 안에서 계속 문자열을 추가 변경하는 코드에서는 string 대신 StringBuilder를 사용해야 한다.
             */


            // 다음과 같이 26을 이용하는데에는 그 이유가 있다.
            //만약 소수 사용자가 26개의 숫자를 처리하고 끝난다면 문제는 stirng을 사용해도 문제가 없지만
            //수만명이 사용하거나 (웹사이트 같은 경우) 루프가 수만개씩 돌 경우에 순간 메모리가 급격하게 증가할 수 있기 때문에 stringbuilder를 사용한다.
            // 루프상에서 문자열의 처리나 추가가 일어날 경우 스트링 빌더를 쓴느것이 낫다.
            //특히 특정 시간대에 사용자가 몰리는 웹사이트 같은 경우, 위와 같은 루프로 인해 메모리가 급격히 증가하는 경우가 많기에 다음과 같은 코드를 쓰는것이 유리하다.

            StringBuilder sb = new StringBuilder(); // 대충 변경 가능하다.
            for (int i = 1; i <= 26; i++)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
            }
            string s_1 = sb.ToString();

            Console.WriteLine(s_1);
        }
    }
}
