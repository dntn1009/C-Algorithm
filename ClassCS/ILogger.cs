using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCS
{
    /*
     * 인터페이스는 클래스와 비슷해 보이지만 메소드, 인덱서, 프로퍼티만 사용할 수 있다.
     * 인터페이스 사용 키워드 : interface
     * 인터페이스는 접근 지정 한정자를 사용할 수 없고, 모든 항목이 public으로 선언된다.
     * 인터페이스는 선언만 가능하고 정의는 할 수 없다.
     * 인터페이스는 상속을 할 수 있고, 클래스, 구조체, 인터페이스에 상속할 수 있다.
     * 
     * 나중에 추가하면 이 Interface를 쓰는 모든 class들은 다 수정을 해야되므로 공통된 사항만 간결하게 넣도록 한다.
     * 그러나 interface를 상속받게 하면 이게 해결이 된다.
     */
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IformattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args);
    }
}
