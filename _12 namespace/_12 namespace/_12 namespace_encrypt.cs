using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12_namespace; // using 을 사용할 경우, 해당 스페아스가 아니더라도 사용이 가능하다.

namespace _12_namespace_util // 다음과 같이, util로 넘어가게 된 경우, 이를 사용할수 없다. 이를 위해 using 이 존재한다. 
{
    class _12_namespace_encrypt
    {
        static void Main(string[] args)
        {
            MyStruct a = new MyStruct();
            Encryptor enc = new Encryptor();
        }
    }

    class Encryptor
    {

    }
}
