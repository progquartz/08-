using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_enum
{
    class Program
    {
        enum Item // 디폴트일 경우에는 그 시작이 0이다.
        {
            Coffee,
            Tea,
            Icecream,
            Bread
        }
        enum Item2 // 하지만 가장 처음의 것을 정하게 되면, 그 숫자부터 카운팅 되기 시작한다.
        {
            Coffee = 1,
            Tea,
            Icecream,
            Bread
        }

        // flag속성의 경우는 각자 값이 고유값을 가지도록 해준다 (즉슨 각 0/1 단위를 하나씩 담당한다..)
        [Flags]
        enum Border
        {
            None  = 0,  // 0000 0000
            Top = 1,    // 0000 0001
            Right = 2,  // 0000 0010
            Bottom = 4, // 0000 0100
            Left = 8    // 0000 1000
        }
        static void Main(string[] args)
        {
            //Order(1, 3);  // coffee 3잔 주문이란걸 알고 있어야 하는데, 이를 다른 사람들이 읽지 못하기 때문에 해결하기 위해 만든것이 바로 enum 타입이다.
            Order(Item2.Coffee, 3); // 이렇게 하면 보기 참 편하다.

            Border b = Border.Top | Border.Bottom; // 1과 4를 더한 5의 값이 b값이 된다. 이로써 상태 표기가 가능해지는것.

            if( (b & Border.Top) != 0) // b가 0101이 되는데, 이는 그러면 0101 & 0001 이니까, 1이 되기 때문에, 0이 아니면 그 피트가 없다는 뜻이니 그 top이 있는지 체크하는 것을 의미한다.
            {
                
            }
            // 근데 저 위처럼 하면 복잡하기 때문에, 또 새로운걸 만들어놓으셨다!
            if (b.HasFlag(Border.Top | Border.Bottom))
            {
                Console.WriteLine(b.ToString());
            }
        }

        static void Order (Item2 item, int qty)
        {
            switch (item)
            {
                case Item2.Coffee:
                    // Make coffee
                    break;
                case Item2.Icecream:
                    // Make 2
                    break;
                case Item2.Tea:
                    // Make 3
                    break;
                case Item2.Bread:
                    // Make 4
                    break;
                default:
                    // Bread and serve
                    break;

            }
        }
    }
}
