using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_class
{
    class _14_class_brick // brick 이라고 하는 클래스 안에 벽돌에 대한 고유한 정보들을 표현하기 위해 field를 사용한다.
    {
        // 필드 (데이터)
        private int width;
        private int height;
        private int depth;
        // 이 사이에 레퍼런스 (참조) 에 대해 잠시 사용하는데, 참조 관리자를 이용해, System.Drawing을 사용할수 있게 되었다.

        private Color color;// 추가로, ctrl + . 을 누르면, 필요한 using 을 자동으로 넣어주도록 창이 뜬다....!

        // 생성자 constructor
        // 생성될때 호출되는 특별한 메소드.
        public _14_class_brick() // 생성자는 클래스와 이름이 같으며, public이 있어 접근 제한자가 public이어야만 한다. private면 이 클래스 내에서만 사용된다.
                                 // 생성자는 일반적으로 field의 값을 초기화하는데에 있다.     
                                 // 이런 형태는 고정된 형태만 받는다는 단점이 있다. 다른 생성자를 정의해보자. (오버라이드.)                               
        {
            width = 10;
            height = 10;
            depth = 5;
            color = Color.Red;
        }

        public _14_class_brick(int width , int height , int depth, Color color) // 이렇게 하면 4개의 입력받은 값을 받아 이를 필드에 넣는다. 
        {
            this.width = width; // 자신의 멤버에 접근할때는 this. 을쓰면 된다. 이름이 다르다면 굳이 사용할 필요가 없당.
            this.height = height;
            this.depth = depth;
            this.color = color;
        }

        // 기초적으로 System.object에서 상속받은 다른 친구들이 있다.
        // 이를 엑세스 하기 위해서는 public 으로 객체 데이터 일부를 받을 수 있도록 하자.
        // 속성 (Property)

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value > 0)
                    this.width = value;
                else
                    Console.WriteLine("에라이 이쌍화차야");
            }
        }
        public Color Color
        {
            get { return this.color;  }
        }

        public int Volume
        {
            get { return width * height * depth; }
        }

        // 메서드

        public void MakeBrick()
        {
            // 세가지 공정을 통해 벽돌을 만든다고 가정한다면, 메서드에서 입력 파라미터를 받아들이고, 리턴 타입을 정하게 되어있는데, 생성자는 특수한 타입이기에, 리턴 타입이 없다.
            // 
            if(ProcessStarted != null)
            {
                ProcessStarted(this, EventArgs.Empty); // 이를 두고 event를 fire한다 라고 한다.
            }
            Step1();
            Step2();
            Step3(); 
            if(ProcessCompleted!= null)
            {
                ProcessCompleted(this, EventArgs.Empty);
            }
        }

        private void Step1()
        {
            Console.WriteLine("Step 1");
        }

        private void Step2()
        {
            Console.WriteLine("Step 2");
        }

        private void Step3()
        {
            Console.WriteLine("Step 3");
        }

        // 이벤트.
        // 이벤트는 클래스 내에 무슨 일이 일어났을떄 클래스에 이를 알리는 것이다.
        public event EventHandler ProcessStarted;
        public event EventHandler ProcessCompleted;
    }
}
