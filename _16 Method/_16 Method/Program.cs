using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int val = 100;
            p.Calculate(val);
            // val는 그대로 100 

            // ref 사용. 초기화 필요.
            int x = 1;
            double y = 1.0;
            double ret = GetData(ref x, ref y);

            // out 사용. 초기화 불필요.
            int c, d;
            bool bret = GetData(10, 20, out c, out d);

            // parameter 연결
            Program p1 = new Program();
            int ret1 = p.Calc(1, 2);
            ret1 = p.Calc(1, 2, "*");
        }

        /*
        클래스내에서 일련의 코드 블럭을 실행시키는 함수를 메서드라 부른다. 메서드는 0 ~ N개의 인수를 갖을 수 있으며, 하나의 리턴 값을 갖는다.
        리턴 값이 없으면 리턴 타입을 void로 표시한다. 또한 public, private 같은 접근 제한자를 리턴 타입 앞에 둘 수 있다. 아래는 전형적인 메서드의 예이다.
        이는 a,b,c 라는 3개의 인수를 받아 들이고, int 타입의 데이타를 리턴하는 public 메서드이다. 
         */

        /*
       C#은 메서드에 인수를 전달할 때, 디폴트로 값을 복사해서 전달하는 Pass by Value 방식을 따른다.
       만약 전달된 인수를 메서드 내에서 변경한다해도 메서드가 끝나고 함수가 리턴된 후, 전달되었던 인수의 값은 호출자에서 원래 값 그대로 유지된다.  
       */
        private void Calculate(int a)
        {
            a *= 2;
        }

        /*
        메서드에 파라미터를 전달할 때, 만약 레퍼런스(참조)로 전달하고자 한다면 C# 키워드 ref를 사용한다. 
        ref를 사용할 경우 메서드 내에서 변경된 값은 리턴 후에도 유효하다. ref를 사용하기 위해서는 ref로 전달되는 변수가 사전에 초기화되어져야 한다.

        C#의 ref와 비슷한 기능을 하는 것으로 C# out 키워드가 있다. out을 사용하는 파라미터는 메서드 내에서 그 값을 반드시 지정하여 전달하게 되어 있다.
        C#의 ref는 해당 변수가 사전에 초기화되어야 하지만, C# out은 사전에 변수를 초기화할 필요는 없다. 
         */

        // ref 정의
        static double GetData(ref int a, ref double b) // 다음과 같은 경우에는 레퍼런스를 두고 a와 b를 넘기므로, 이같은 경우는 a와 b에 대한 직접적 수정이 가능해진다.
        { return ++a * ++b; }

        // out 정의
        static bool GetData(int a, int b, out int c, out int d) // 메서드 내에서 값을 지정하여 전달함.
        {
            c = a + b;
            d = a - b;
            return true;
        }


        // c#에 파라미터를 전달할때, 일반적으로 파라미터 위치에 따라 순차적으로 파라미터가 넘겨진다. 
        // c# 4.0부터는 하지만 위치와 상관없이, 파라미터명을 지정하여 파라미터를 전달할 수 있게 되었다. 이를 두고 Named parameter라고 한다.

        // Optional 파라미터: calcType
        // Named parameter는 가독성을 증가시키고, optimal parameter 화한 값을 어떤것으로 호출하는지 확인하게 좋게 해준다.
        int Calc(int a, int b, string calcType = "+")
        {
            switch (calcType)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    throw new ArithmeticException();
            }
        }

        /*
        일반적으로 메서드의 파라미터 갯수는 고정되어 있다. 하지만 어떤 경우는 파라미터의 갯수를 미리 알 수 없는 경우도 있는데, 이런 경우 C# 키워드 params를 사용한다.
        이 params 키워드는 가변적인 배열을 인수로 갖게 해주는데, 파라미터들 중 반드시 하나만 존재해야 하며, 맨 마지막에 위치해야 한다. 
         */ 
        //메서드 예제.
        /*
         * int Calc(params int[] values) .// 다음과 같이, calc 함수에서 params int[] value를 사용했는데, 파타미터의 갯수를 알 수 없는 경우인 지금과 같은 경우는 params를 사용했다.
         *                                // 가변적인 배열을 인수로 가진다에 꽤나 신박한 방법을 사용핤 수 있는듯 하다.

        //사용
        int s = Calc(1, 2, 3, 4);
        s = Calc(6,7,8,9,10,11);
        
         */

    }
}
