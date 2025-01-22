using UnityEngine;
/// <summary>
/// class for rotationg cube object
/// </summary>

public class CubeRotate : MonoBehaviour
{
    // 트랜스폼이라는 클래스를 찾아서 rotation에 관련된 컴포넌트를 수정해보자.
    // public으로 선언하면 유니티화면상 인스펙터 창에서 찾을수 있다는 것이다.

    #region data type summary
    // 자료형 타입
    // int 정수
    // float 실수
    // bool True or false 반환함 -> if문 실행될지 안될지 결정해줄수있3
    // string 문자집합
    // 컴퓨터가 데이터의 타입을 판단하는 기준
    #endregion


    #region variable
    // 변수의선언 -> data type를 지정하고 변수명을 입력하면 데이터를 저장하기 위한 공간생성
    [Header("setting")]
    
    public float x; // 유니티 에디터에서 공개됨
    public float z;

    private int sample; // 유니티에서 공개가 안되는 변수
    #endregion

    

    void Start()
    {
        sample = 10;
        Debug.Log(sample);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x * Time.deltaTime, 0, z * Time.deltaTime));
        // 벡터3도 유니티에서쓰는 하나의 자료형 , 벡터값 0은 회전하고 싶지 않다 라고 해석할수있음
        // deltaTime의 역할 : 한 프레임에 소요되는 단위시간 , fps = 초당 프레임
    }
}
