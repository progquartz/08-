using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _02_Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true; // 0과 1로 (1 이상도 가능은 함) 이루어진 것 (1바이트)

            int i = 100; // 정수 (32비트/4바이트)
            short sh = 100; // 정수 (16비트/2바이트) 최대 정수의 크기가 더 작음.
            long lo = 100; // 정수 (64비트 / 8바이트) 최대 정수의 크기가 더 큼.
            // 부호가 있는 경우 signed integar 라고 하고, 없는 양수만 필요한 경우는 unsigned 를 이용해주자.
            uint ui = 100; // 신기하게 unsigned 가 u로 간결화되버렸다. 신기
            ushort us = 100;
            ulong ul = 100ul;

            
            double d = 3.141592d; // 소숫점이 있는 숫자.(64비트 / 8바이트)
            float f = 3.141592f; //f를 끝에다가 적어야만함. 소숫점이 있는 숫자, (32비트/ 4바이트) double 보다 표현할수 있는 자리수가 작음.
            decimal de = 3.141592m; // m 을 끝에다가 적어야만 함. 소숫점이 있는 숫자 (128비트 / 16바이트) double보다 표현할 수 있는 자리수가 큼.

            int ix = null; // 본디 int는 value 타입이기 때문에, null 값을 가질 수 없다.
            int? ix2 = null; // 하지만, ?를 넣으면 null 값이 사용이 가능해지는데.. 여기에서 ? 값이 뭔 짓을 하는지를 알아봐야 한다.

            if(ix2 == null)
            {
                Console.WriteLine("ix2 is null");
            }
            else
            {
                Console.WriteLine(ix2.Value);
            }
            // 문자 관련은 Null 값 지정이 가능하다. (value 타입과 reference 타입.)
            string s = "Hello"; // 문자열 (1바이트 * 개수 + 1)
            string s1 = null;

            char ch = '한'; // 한 문자. 유니코드의 경우 4바이트다.

            byte by = 0x46; // 2바이트

            object o = 123; //모든 데이터타입을 담을 수 있는 타입! (충격) 오토와 유사한건지 알아봐야함.
        
    
        }
    }
}
