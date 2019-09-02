#define STANDARD_EDITION
#define ENTERPRISE_EDITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if (!ENTERPRISE_EDITION)
#warning This class should be used in Enterprise Edition
#endif

namespace _18_preprocessor_directive
{
    class EnterpriseUtility
    {
    }
}

// #error 예제 --------------------------------------


#if (STANDARD_EDITION && ENTERPRISE_EDITION)
#endif

namespace App1
{
    class Class1
    {
    }
}
/*
#pragma 지시어는 위의 표준 C# 전처리기 지시어와 다르게, 컴파일러 제작업체가 고유하게 자신들의 것을 만들어 사용할 수 있는 지시어이다. 
즉, 어떤 컴파일러를 쓰느냐에 따라 지원되는 #pragma가 서로 다르며, 개발자가 임의로 지정하여 사용할 수 없다.

MS의 C# 컴파일러는 현재 #prama warning과 #pragma checksum 2개를 지원하고 있다.
#prama warning는 경고메서지를 Disable/enable 하게 할 수 있으며, #pragma checksum는 주로 ASP.NET 페이지 디버깅을 위해 만들어진 것으로 
ASPX 페이지의 파일 체크섬을 생성할 때 사용된다. 
     */
namespace App1
{
    [System.CLSCompliant(false)]
    class Program
    {
        static void Main(string[] args)
        {
            //...

#pragma warning disable
            if (false)
            {
                Console.WriteLine("TBD");
            }
#pragma warning restore

            //...
        }
    }
}