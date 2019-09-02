#define TEST_ENV
#undef  DEBUG // 만약 다음과 같이, DEBUG같은것을 해제시키면, #if (DEBUG)와 같은 놈들은 다 꺼져버린다.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _18_preprocessor_directive
{
    class Program
    {
        public string GetServer()
        {
            string server;
#if (TEST_ENV)
            server = "TEST SERVER"; // TEST_ENV의 define된 부분이 있으면 선택적으로 아래의 요소만을 컴파일함. 
                                    //이러한 define은 한 파일 내에서만 적용되는데, 만약 프로젝트 전체에 대한 프로젝트를 진행하고 싶다면 다른 방식을 사용해야만 한다.
                                    // 설정 -> 빌드 -> 상태적 기호 뭐시기 -> 설정 축
                                    // 그리고 그 아래에 있는 define debug constant와 define trace constant의 경우는
                                    // 이들은 각각 debug와 trace라는 심벌을 사용할수 있다는 의미이다. 
#else
            server = "PROD SERVER";
#endif
            return server;

        }
        /*
         #region은 코드 블럭을 논리적으로 묶을 때 유용하다. 예를 들어, Public 메서드들만 묶어 [Public Methods]라고 명명할 수 있고,
         Private 메소드들을 묶어 [Privates] 라고 명명할 수 있다.

        #region은 #endregion과 쌍을 이루며 한 영역을 형성한다. #region 안에 다른 Nested Region을 둘 수도 있다. 
        Visual Studio에서 #region 영역은 좌측에 +/- 로 표시되어 Expand/Collapse를 할 수 있는 기능을 제공한다. 
        이 전처리기 지시어는 실제 가장 많이 사용되는데, 특히 복잡하고 긴 클래스를 개념적으로 묶을 때 매우 유용하다.
             */
        class ClassA
        {
            #region Public Methods 
            public void Run() { }   // region을 시작.     
            public void Create() { } // region이 끝남.
            #endregion  

            #region Public Properties
            public int Id { get; set; }
            #endregion

            #region Privates
            private void Execute() { }
            #endregion
            // 옆의 + - 창을 이용하면 간단하게 줄여지므로, 앞에 글처럼 사용될때가 많은듯 하다.
        }

        /*
         #elif 는 #if와 함께 사용하여 else if를 나타낸다.
#line 은 거의 사용되진 않지만, 라인번호를 임의로 변경하거나 파일명을 임의로 다르게 설정할 수 있게 해준다.
#error 는 전처리시 Preprocessing을 중단하고 에러 메시지를 출력하게 한다.
#warning 은 경고 메서지를 출력하지만 Preprocessing은 계속 진행한다.
warning과 error는 특정 컴포넌트가 어떤 환경에서 실행되지 않아야 할 때 이를 경고나 에러를 통해 알리고자 할 때 사용될 수 있다.

아래 코드는 (1) 첫번째 예제는 Enterprise Edition이 아닌 경우 경고 메시지를 내는 것을 보여주고, (2) 두번째 예제는 Edition 심벌이 복수로 지정된 경우에 에러를 내게 하는 케이스를 예시하고 있다. 만약 여러 개의 파일들을 병합한 후, 컴파일을 해야하는 경우 이러한 에러 체크가 유용할 수 있다.
             */
        static void Main(string[] args)
        {
        }
    }
}
