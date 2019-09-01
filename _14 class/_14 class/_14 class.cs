using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // 클래스와 객체에 대해 이야기하자면, 클래스는 벽돌틀과 같다고 한다. 벽돌틀에 들어가는 재료, 종류, 색깔, 질감 등이 정해져야만 하고, 이로 만들어지는 벽돌들이 객체/인스턴스라고 한다.
            // 한개의 벽돌틀에서 여러 벽돌을 만들수 있듯이, 한클래스로 여러 객체를 만들 수 있다. 
            _14_class_brick br = new _14_class_brick(); // 이렇게 클래스를 통해 새로운 객체를 만들어내셨다! 생성자를 사용했따.
            _14_class_brick br2 = new _14_class_brick(10, 20, 30, System.Drawing.Color.Green);

            Color a = br2.Color; // 속성에 접근이 가능해졌다. 
            int w = br2.Width;
            br2.Width = 10; // 다음과 같이 set을 통해 받아내는것도 가능하다.. 
            int v = br2.Volume;
            br2.MakeBrick(); // 메서드
            br2.ProcessStarted += Br2_ProcessStarted; // br2.ProcessStarted += 상태에서 tab누르면 다 만들어짐.
            br2.ProcessCompleted += Br2_ProcessCompleted;
        }

        private static void Br2_ProcessCompleted(object sender, EventArgs e) // 입넽 상황일 경우, 다음과 같은걸 실행하도록 만들어지는 구문이 자동으로 만들어진다 개꿀따리..
        {
            //....
            Console.WriteLine("Process Ended");
        }

        private static void Br2_ProcessStarted(object sender, EventArgs e)
        {
            //...
            Console.WriteLine("Process started");
        }
    }
}
