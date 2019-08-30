using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_if_and_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             if 문은 조건식이 참, 거짓인지에 따라 서로 다른 블럭의 코드를 실행하게 한다. 
             예를 들면, if (조건식) { 블럭1 } else { 블럭2 } 문장의 경우, 조건식이 참이면 블럭1을 실행하고, 거짓이면 블럭2를 실행한다.

             아래 예제는 a값이 0 이상이면 val는 a 값을 그대로 갖고, 0보다 작으면 -a 값을 갖는 표현이다.
             */
             // 사실 지금 당장 if문에 대해 모를린 없으므로, 추가적이 사항이 없으면, 더이상 적지 않을 예정.
            int val;
            int a = -11;

            if (a >= 0)
            {
                val = a;
            }
            else
            {
                val = -a;
            }

            // 출력값 : 11
            Console.Write(val);

            /*
             switch 문은 조건값이 여러 값들을 가질 경우 각 case 별 다른 문장들을 실행할 때 사용된다. 
             각각의 경우에 해당하는 값을 case 문 뒤에 지정하며, 어떤 경우에도 속하지 않는 경우는 default 문을 사용해 지정한다.
             각 case문 내에서 break 문을 사용하게 되면 해당 case 블럭의 문장들을 실행하고 switch 문을 빠져 나오게 된다.

            아래 예제에서 만약 category값이 딸기라면 price는 1100원이 된다.
             */

            string category = "사과";
            int price = 0;

            switch (category)
            {
                case "사과":
                    price = 1000;
                    break;
                case "딸기":
                    price = 1100;
                    break;
                case "포도":
                    price = 900;
                    break;
                default:
                    price = 0;
                    break;
            }
        }
    }
     // 예제가 있길래 한번 이해해보자.
    class Program2
    {
        static bool verbose = false;
        static bool continueOnError = false;
        static bool logging = false;

        static void Main(string[] args)
        {
            if (args.Length != 1) // 받은 string의 길이가 1이 아닌 경우, 아래의 텍스트를 방출
            {
                Console.WriteLine("Usage: MyApp.exe option");
                return;
            }

            string option = args[0];
            switch (option.ToLower()) // option의 모든 영어중 대문자를 소문자로 바꾼 다음에, switch 문에 검사 후, 경우에 맞는 경우가 있으면, 다음을 진행. 
                                      //break를 사용하지 않으면서 신기하게 switch문을 사용하는 방식을 확인함.)
            {
                case "/v":
                case "/verbose":
                    verbose = true;
                    break;
                case "/c":
                    continueOnError = true;
                    break;
                case "/l":
                    logging = true;
                    break;
                default:
                    Console.WriteLine("Unknown argument: {0}", option); // 아무런 
                    break;
            }
        }
    }
}
