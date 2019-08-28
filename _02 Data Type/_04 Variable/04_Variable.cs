using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Variable
{
    class CSVar
    {
        //필드 (클래스 내에서 공통적으로 사용되는 전역 변수)
        int globalVar; // global variable 이라는 int 변수를 선언.
        const int MAX = 1024; // 정수 Max 1024 선언.

        public void Method1() // 메소드 1을 선언.
        {
            // 로컬변수
            int localVar; // 로컬변수를 만든 다음에, 값을 할당.

            // 아래 할당이 없으면 에러 발생
            localVar = 100;

            Console.WriteLine(globalVar); // global Variable 을 소환하고.. (클래스 내에 있는 변수이기 때문에, 클래스 내의 어디에서든간에 사용할 수 있다.)
            Console.WriteLine(localVar); // local variable은 클래스 내의 변수가 아닌 함수 (메소드) 안의 변수이기 때문에, 그 함수 내에서만 사용할 수 있다.
        }

        /*
         C# 상수는 C# 키워드 const를 사용하여 정의한다. C# 변수와 비슷하게 선언하는데, 다만 앞에 const를 붙여 상수임을 나타낸다.
         상수와 변수의 차이점은, 변수는 프로그램 중간에 값을 변경할 수 있지만, 상수는 초기에 정한 값을 중간에 변경할 수 없다.
         const는 필드 선언부에서 사용되거나 메서드 내에서 사용될 수 있으며, 컴파일시 상수값이 결정된다.

        C# const 대신 readonly 키워드를 사용하여 읽기전용 (개념적으로 상수와 비슷한) 필드를 만들 수 있다.
        readonly는 필드 선언부나 클래스 생성자에서 그 값을 지정할 수 있고, 런타임시 값이 결정된다)
        */
        const int MAX_VALUE = 1024; // 상수.

        readonly int MAXr; // 오직 읽기 전용으로 쓰일 수 있는 변수. readonly라는것이 상수와 다른 부분이 무엇이 있는지 확인해야 할것 같다.
        public CSVar()
        {
            MAXr = 1; // 초기화. 읽기용으로만 가능한 int이기 떼문에, 초기화할때 값을 지정해주어야만 한다.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* 모든 C# 변수의 이름은 대소문자를 구별한다.
             C# 변수는 메서드 안에서 해당 메서드의 로컬변수로 선언되거나, 
             혹은 클래스 안에서 클래스 내의 멤버들이 사용하는 전역적 변수(이를 필드(Field)라고 부름)로 선언될 수 있다.
             
            로컬변수는 해당 메서드내에서만 사용되며, 메서드 호출이 끝나면 소멸된다.
            반면 필드는 클래스의 객체가 살아있는 한 계속 존속하며 또한 다른 메서드들에서 필드를 참조할 수 있다.
             */
            // 테스트
            CSVar obj = new CSVar(); // obj라는 이름의 CSVar 클래스를 만든 다음, 새로운 Csvar의 값을 붙어넣음.
            obj.Method1(); // 이럴 경우 glovalVar는 값을 명시하지 않으면 0이 된다. 하지만 localVar는 값을 할당하지 않으면 compile error가 난다. 

        }
    }
}
