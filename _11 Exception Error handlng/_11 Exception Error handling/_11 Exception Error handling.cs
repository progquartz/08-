using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11_Exception_Error_handling
{
    class Program
    {
        /*
         * 
         * 예제는 다음과 같다. try에서 실행하고자 하는 문장들을 넣고, catch에 예외예제인 exception을 넣으면, 이에 대항되는 에러 처리/ 로그 등이 Exception에 저장된다.
         * 이를 두고 로그를 남기거나, 등의 일을 하면 된다.
         try
        {
        // 실행하고자 하는 문장들
        DoSomething();
        }
        catch (Exception ex)
        {
        // 에러 처리/로깅 등
        Log(ex);
        throw;
        }
         */
        static void Main(string[] args)
        {
            try
            {
                Run();
                //....
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); // throw 다음과 같이 오류가 나면 오류가 난 상태로 멈추지 않고 이에 대한 에러를 적어준 다음에 다음으로 그냥 넘긴다!
                                               // 와 너무 행복하요
            }
            Console.WriteLine("Next Step!");
            //...
           
        }

        static void Run()
        {
            try
            {
                int[] a = new int[10];
                for (int i = 0; i <= 10; i++) // 오류가 날 부분. i <= 10 이 아니라, i < 10으로 해 인덱스 범위를 넘는다.
                {
                    a[i] = i;
                    Console.WriteLine(a[i]);
                }

                var fs = File.Open("my.config", FileMode.Open); // 이건 System.IO에서 사용하는 친구다. 말도 안하고 추가해버리다니..
            }
            catch(IndexOutOfRangeException ex) // 이 문제에 대한 catch만을 하는 친구이다. 이 친구가 없으면, 다음으로 간다. 순서대로라는것이 중요하다.
            {
                //...
            }
            catch(FileNotFoundException ex)
            {
                //Use Default value
                //... 만약 이에 대한 해결을 try catch문으로 해결하게 할 수도 있다.! 오올ㅋ
            }
            catch(Exception ex) // 모든 exception이기때문에, 상위이어서 포괄적이기에 이는 대부분 좁은 범위 다음인 가장 마지막에 두는것이 옳다.
            {
                //...
                Log(ex);
                throw; // throw에는 3가지 종류가 있다. 첫번째것은 그대로 호출받은걸 전달하고
                throw ex; // 두번째거는 이 exception을 받아 저장하지만 기존의 콜스텍 정보를 삭제하고 여기서부터 시작되는 콜스택 정보를 리턴한다.
                throw new ApplicationException(ex.Message , ex); // 새로운 exception을 만들어서 보낸다. 래핑해서 보내거나, 자신만의 커스텀 exceptoin을 만들어 보낼때 사용한다.
                                                  //  이 방식은 새로운 exception을 만드는것이기 때문에, 기존의 exception 자료를 잃지 않도록 해야 한다.
                                                  // 새로운 exception은 생성되어 뒤에 놓는것이 Innerexception이라는게 되는데, 현재 exception을 새 exception으로 두는것이 좋다.
            }
            finally // 그리고 finally는 마지막으로 실행된다.
            {
                
            }
        }

        static void Log(Exception ex)
        {
            // File, DB 로깅

        }
    }
}
