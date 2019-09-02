using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Nullable_type
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            C#에서 정수, 부동자릿수, 구조체 등의 Value Type은 NULL을 가질 수 없다. 
            예를 들어, 정수 int i 가 있을 때 변수 i에는 null을 할당할 수 없으며, 따라서 변수 i는 어떤 값이 할당되지 않은 상태 (missing value)를 가질 수 없다.
            만약 정수형 변수 i에 값이 설정되지 않은 상태를 할당하려면, 개발자는 2가지 방법을 사용할 수 있을 것이다.
            즉, (1)프로그램에서 사용될 것 같지 않은 특정 값을 추정하여 할당하던지 (예를 들어, int i = int.MaxValue;) 
            (2) 아니면 또 하나의 변수를 두어 변수 i가 missing임을 나타내게 할 수 있다 (예를 들어, bool iHasValue = false;).
            이 두번째 방식이 Nullable의 기본 아이디어이다.

            C# 에서는 Value Type에도 null을 할당할 수 있는 Nullable 타입을 지원한다.
            Nullable 타입은 Value 값을 갖고 있으면서 NULL 상태를 체크할 수 있는 기능(HasValue)을 함께 가지고 있는 struct 이다.
            따라서 Nullable 타입은 struct(구조체)이므로 Value Type이다.

            C#에서 int? 와 같이 해당 Value Type 뒤에 물음표를 붙이면, 해당 정수형 타입이 Nullable 정수형 타입임을 의미한다.
            즉, 이 변수에는 NULL을 할당할 수 있다. C#의 이러한 특별한 문법은 .NET의 Nullable<T> 구조체로 컴파일시 변환된다. 즉, int?는 Nullable<int>와 동일하다.
             */

            Nullable<int> i = null; // int ? 와 Nullable <> 는 같다.
            int? i2 = null; // ? 를 붙이는것이 nullable type가 되게하는 주문인건가
            bool? b = null;
            int?[] a = new int?[100]; // ?를 계속해서 넣어줘야만 한다. 아예 다른 친구 취급하는듯.


             // 정적클래스 개꿀
            /*
            Nullable<T> 구조체는 값을 가지고 있는지를 체크하는 (즉, missing value가 아닌지를 체크하는) HasValue 속성과 실제 값을 나타내는 Value 속성을 가지고 있다.
            Nullable 구조체는 타입 캐스팅을 통한 변환이나 암묵적 변환을 통해 (Non-nullable) Value 타입으로 변환된다. 

            Nullable 타입이 실무에서 흔히 사용되는 케이스는 DB와 연동되는 Data Layer 클래스들을 들 수 있는데, 예를 들어 SQL 서버 테이블에서 NULL을 허용하는 숫자,
            날짜, bool등의 컬럼이 있다면, 이 컬럼 타입은 Nullable 타입으로 변환되어 테이블의 NULL 속성을 표현하게 된다. 
            
            Nullable 타입과 연관되어 자주 사용되는 C#의 ?? 연산자는 ?? 앞의 파라미터가 NULL인 경우 연산자 뒤의 값을 할당할 때 사용한다. 
            아래 예제는 다양한 종류의 Nullable 파라미터를 받아들여 HasValue로 NULL 값을 미리 체크한 후, .Value 속성을 써서 해당 타입의 실제 값을 사용하고 있다.
             */
        }

        double _Sum = 0;
        DateTime _Time;
        bool? _Selected;

        public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
        {
            if (i.HasValue && d.HasValue)
                this._Sum = (double)i.Value + (double)d.Value;

            // time값이 있는 체크.
            if (!time.HasValue)
                throw new ArgumentException();
            else
                this._Time = time.Value;

            // 만약 selected가 NULL이면 false를 할당
            this._Selected = selected ?? false;
        }

        /*
        .NET Framework에 있는 정적(static) 클래스 System.Nullable 은 두개의 Nullable 객체를 비교하거나 (Compare(), Equals() 메서드),
        특정 Nullable 타입이 어떤 Value 타입에 기반을 두고 있는지 알아내는 (GetUnderlyingType() 메서드) 기능을 제공하고 있다.
        이 정적 클래스는 Nullable<T> 타입을 위한 몇 가지 편리한 정적 메서드들을 제공한다. 
        */

        void NullableTest()
        {
            int? a = null;
            int? b = 0;
            int result = Nullable.Compare<int>(a, b); // 비교하는 거, null값이 있기 때문에 비정상적인 값이 감지되어 -1값이 도출되었다. 큰지 작은지 같은지를 비교한다.
            Console.WriteLine(result); //결과 -1

            double? c = 0.01;
            double? d = 0.0100;
            bool result2 = Nullable.Equals<double>(c, d); // 같은지 물어보는것, Equals()는 같은지 아닌지만 비교한다. 소팅 같은 기능을 위해서는 Equals 가 아닌 Compare가 필요하다.
            Console.WriteLine(result2); //결과 true
        }
    }
}

