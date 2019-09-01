using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_namespace // 그리고 _12_namespace 라고 하는 namespace 가 정의되어있다. 처음 프로젝트를 만들때 myproject를 썼는데, namespace 의 default 이름이 프로젝트 명과 같아진다.
{
    class Program// 클래스 프로그램이라고 클래스 1개가 정의되어있고 한개의 프로젝트 내에서는 여러개의 클래스들을 생성할 수 있다. 
    {
        static void Main(string[] args) // 이 메인 메소드 등을 
        {
            A a = new _12_namespace.A(); // 같은 
        }
    }

    class A //  한개의 프로젝트 내에서는 여러개의 클래스들을 생성할 수 있다. 
    {

    }

    class B
    {

    }

    struct MyStruct // 하나의 namespace 안에 여러개의 구조체나, enum등을 다 넣을 수 있다. 일종의 논리적인 컨테이너같은거다. 동일한 네임스패이스 안의 것들은 불러서 사용가능하다. 
    {

    }

    enum MyEnum
    {

    }
}
