using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             c#에는 2가지 타입이 있는데, value type와 reference type가 있다. struct는 value type고, class는 reference type이다. 

            C# .NET의 기본 데이타형들은 struct로 정의되어 있다. 즉, int, double, float, bool 등의 기본 데이타 타입은 모두 struct로 정의된 Value Type이다.
            Value Type은 상속될 수 없으며, 주로 상대적으로 간단한 데이타 값을 저장하는데 사용된다.

            Reference Type은 class를 정의하여 만들며 상속이 가능하고, 좀 더 복잡한 데이타와 행위들을 정의하는 곳에 많이 사용된다.
            Value Type의 파라미터 전달은 데이타를 복사(copy)하여 전달하는 반면, Reference Type은 Heap 상의 객체에 대한 레퍼런스(reference)를 전달하여 이루어진다.
            구현에 있어 어떤 Type을 선택하는가는 해당 Type의 특성을 고려해서 결정해야 하는 문제이다. 


             */

            // 구조체 사용
            MyPoint pt = new MyPoint(10, 12);
            Console.WriteLine(pt.ToString());
        }

        // 구조체 정의
        struct MyPoint // 사실 기존의 c++  구조체와 크게 다를게 없다. 다행..
        {
            public int X;
            public int Y;

            public MyPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1})", X, Y);
            }
        }


    }
}
