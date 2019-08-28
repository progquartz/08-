using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             배열은 일련의 같은 데이터 타입의 변수들을 일렬로 정렬시켜 각각을 엑세스할수 있도록 만들어낸것이다. 
             c#에서도 다른 c, c++ 처럼 가장 처음의 배열의 인덱스가 0이다.
             배열의 요소는 [] 안에 넣어 표시한다. ex) int a[5]

             c#은 1차 배열, 2차 배열 등 최대 32차 배열까지의 요소를 만들어낼 수 있다... (32차배열..)
             다차원 배열은 각 차원별 크기가 고정된 rectangular 배열과 각 차원의 배열의 크기가 다른 가변형 배열로 나뉜다.
        
             */

            // 1차 배열
            string[] players = new string[10];
            string[] Regions = { "서울", "경기", "부산" };

            // 2차 배열 선언 및 초기화
            string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            // 3차 배열 선언
            string[,,] Cubes;

            /*
             가변배열은 간단하다, 해당 부분에 첫번째 차원의 크기는 정해져야만 하지만, 그 이상의 차원은 컴파일시 동적으로 크기를 지정할 수 있다.
             단순 Rectangular 배열의 메모리 소모가 클 경우 이용한다.
             */

            //Jagged Array (가변 배열)
            //1차 배열 크기(3)는 명시해야
            int[][] A = new int[3][];

            //각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능
            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;

            // 모든 C# 배열은 내부적으로 .NET Framework의 System.Array에서 파생된 것이다. 따라서, System.Array의 메서드, 프로퍼티를 사용할 수 있다. (??)
            /*
             *  다음 예제는 점수 배열(scores)을 하나 하나 엑세스하면서 총합을 구하는 예이다.
             *  아래 예제에서 배열 scores의 사이즈를 구하기 위하여 scores.Length 처럼 .Length 속성을 사용하였는데, 이는 System.Array 클래스에 정의된 속성이다.
             */

            int sum = 0;
            int[] scores = { 80, 78, 60, 90, 100 };
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine(sum);

            // c#에서 배열을 전달하는데에는 보내는 쪽에서는 배열명을 사용하고, 받는 쪽에서 동일한 배열타입의 배열을 받아들이면 된다.
            //배열은 레퍼런스(Reference) 타입이기 때문에, 배열을 다른 객체나 메서드에 전달할 때, 
            //직접 모든 배열 데이타를 복사하지 않고, 배열 전체를 가리키는 참조 값(Reference pointer)만을 전달한다. 

            int[] scores1 = { 80, 78, 60, 90, 100 };
            int sum1 = CalculateSum(scores); // 배열 전달: 배열명 사용
            Console.WriteLine(sum1);

            int[] n = new int[100];
            for(int i = 0; i < n.Length; i++)
            {
                n[i] = i;
            }
            PrintArray(n);
        }

        static int CalculateSum(int[] scoresArray) // 배열 받는 쪽
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }
            return sum;
        }

        static void PrintArray(int[] arr) // 배열을 받아서 이를 프린트하는 함수.
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
