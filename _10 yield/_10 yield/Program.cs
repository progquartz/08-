using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _10_yield
{
    class Program
    {

        static IEnumerable<int> GetNumber()
        {
            yield return 10;  // 첫번째 루프에서 리턴되는 값
            yield return 20;  // 두번째 루프에서 리턴되는 값
            yield return 30;  // 세번째 루프에서 리턴되는 값
        }

        static void Main(string[] args)
        {
            /*
            C#의 yield 키워드는 호출자(Caller)에게 컬렉션 데이타를 하나씩 리턴할 때 사용한다.

            흔히 Enumerator(Iterator)라고 불리우는 이러한 기능은이라는 것을 보자마자 생성자라는 느낌이 왔지만,
            yield 는 집합적인 데이타셋으로부터 데이타를 하나씩 호출자에게 보내주는 역할을 한다.

           yield는 yield return 또는 yield break의 2가지 방식으로 사용되는데, (1) yield return은 컬렉션 데이타를 하나씩 리턴하는데 사용되고,
           (2) yield break는 리턴을 중지하고 Iteration 루프를 빠져 나올 때 사용한다.

           yield 의 간단한 예제로 아래 코드를 살펴보자. GetNumber() 라는 메서드는 3개의 yield return 문을 가지고 있다. 
           만약 외부에서 이 GetNumber()를 호출하게 되면, 첫번째 호출시에는 첫번째 yield return 10 을 실행하여 10을 리턴하게 되고, 
           두번째로 호출되면 yield return 20 이 실행되어 20을 리턴하게 된다. 
           이러한 방식으로 GetNumber()는 한꺼번에 10,20,30을 모두 리턴하는 것이 아니라, 한번 호출시마다 다음 yield return 문의 값을 리턴하는 것이다.
            */

            //이러한 특별한 리턴 방식은 다음과 같은 경우에 유용하게 사용된다.
            /* (1) 만약 데이타의 양이 커서 모든 데이타를 한꺼번에 리턴하는 것하는 것 보다 조금씩 리턴하는 것이 더 효율적일 경우.
             * 예를 들어, 어떤 검색에서 1만 개의 자료가 존재하는데, UI에서 10개씩만 On Demand로 표시해 주는게 좋을 수도 있다. 
             * 즉, 사용자가 20개를 원할 지, 1000개를 원할 지 모르기 때문에, 일종의 지연 실행(Lazy Operation)을 수행하는 것이 나을 수 있다.
             * (2) 어떤 메서드가 무제한의 데이타를 리턴할 경우. 예를 들어, 랜덤 숫자를 무제한 계속 리턴하는 함수는 결국 전체 리스트를 리턴할 수 없다.
             * 고로 이는 yield 를 사용해서 구현하게 된다.
             * (3) 모든 데이타를 미리 계산하면 속도가 느려서 그때 그때 On Demand로 처리하는 것이 좋은 경우.  
             * 예를 들어 소수(Prime Number)를 계속 리턴하는 함수의 경우, 소수 전체를 구하면 (물론 무제한의 데이타를 리턴하는 경우이기도 하지만) 
             * 시간상 많은 계산 시간이 소요되므로 다음 소수만 리턴하는 함수를 만들어 소요 시간을 분산하는 지연 계산(Lazy Calculation)을 구현할 수 있다.             
             */
            foreach (int num in GetNumber()) // 매번마다 하는 foreach 문. 
            {
                Console.WriteLine(num);
            }

            foreach (var score in GetScores())
            {
                Console.WriteLine(score);

            }
        }  
        static IEnumerable<int> GetScores()
        {
            int[] scores = new int[] { 10, 20, 30, 40, 50 };
            for(int i = 0; i < scores.Length; i++)
            {
                if(scores[i] == 30)
                {
                    yield break; // yield를 그만두게 하는 명령어이다. 개꿀따리
                    // 이렇기에 yield는 for each에서 사용하게 된다.
                }
                yield return scores[i];
                Debug.WriteLine(i + ": Done"); // 신기하게 디버그 모드에서만 보여지는 결과값을 볼 수 있다.

            }
        }
    }
}
