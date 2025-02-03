using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class TextCount : MonoBehaviour
{
    // 텍스트에 카운트를 출력하는 기능 구현
    // 카운트는 초마다 계속 1씩 증가하는 형태로 처리

    public Text countText;
    private int count;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine("IEnumrator형태의 함수 이름을 문자열 형태로 함수를찾아서 호출");
        StartCoroutine("CountPlus"); // 문자열 , 문자열을 사용해 코루틴을 멈추는 등의 제어기능을 사용할수 있음
        StopCoroutine("CountPlus");

        //StartCoroutine(함수의이름());
        //해당함수를 호출해 실행결과를 반환받는 형태 -> 오타 발생히 오류체크 가능
        // StopCoroutine 을써서 중지시킬수가 없음
        StartCoroutine(CountPlus()); // 함수를 호출해서 실행하는 방식 , 중지등의 제어는 안되지만 빨리 실행할수있다??
    }

    // 코르틴은 프레임단위의 지침을 내려주는 기능이라 업데이트 함수 안쓴다.
    IEnumerator CountPlus()
    {
        while (true)
        {
            count++;
            countText.text = count.ToString("N0"); // N0 : 3자리마다 쉼표
            yield return null; // move next frame

/*        Debug.Log("mic test over!");
        yield return new WaitForSeconds(1);
        //yield는 일시적으로 시피유의 권한을 다른함수에 위임하는 키워드
        Debug.Log("I'll be back!");
        yield return new WaitForSeconds(5);
        Debug.Log("Sheldor back online");

        int count = 0;
        for (int i=0; i <1000; i++)
        {
            count += 1;
            yield return new WaitForSeconds(1);
            Debug.Log("");
        }*/
        }
    }
}
