using UnityEngine;
using Assets.Sprites;

// using ---- 은 "다음에 적힌 것을 코드에서 사용하는 중이다" 는 의미입니다.
// 유니트 엔진을 활용하는 스크립트는 위의 코드를 반드시 추가하세요.

// namespace는 고유의 공간을 만들어줌, 이름설정할때 주의해야함 기존에 있는것들과 충돌 가능성
// 특정 기능을 하는 클래스의 대표 이름으로 사용됩니다.어떤 영역 혹은 오브젝트에 사용되는 클래스인지 파악가능
namespace UnityTutorial2
{
    // 유니티 튜토리얼이라는 공간을 만들고 그안에 심플A 클래스를 만듦
    public class SampleA
    {

    }
}
// 클래스 내에 다시또 클래스 선언해도 되는데 monobehaviour 는 또 선언하지 말자
public class SampleA
{

}

/// <summary>
/// 처음으로 만들어본 유니티의 스크립트
/// </summary>

public class test : MonoBehaviour
{
    // MonoBehaviour는 클래스에 연결했을 경우
    // 유니티 씬에 존재하는 오브젝트에 스크립트을 연결할수 있게 해줌
    // test란 클래스 파일 , 이갈러 유니티에서 제공하는 기능을 오브젝트에 연결함

    // Assets.Sprites.NewBehaviourScript1 이런식으로 직접 불러올수 있다.
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    /// <summary>
    /// 공격 기능 함수 만들어봄
    /// </summary>
    
    void Attack(float damage)
    {


    }
    void Start()
    {
        Debug.Log("hello unity6");
    }


    int count = 0;

    // Update is called once per frame

    private float timeElapsed = 0f; // 경과 시간 변수
    public float interval = 1f; // 출력 간격 (초)

    void Update()
    {
        timeElapsed += Time.deltaTime; // 프레임 간 경과 시간 추가

        if (timeElapsed >= interval)
        {
            Debug.Log("안녕! 안녕! 안녕!");
            Debug.Log($"{count}");
            count++;
            timeElapsed = 0f;
        }
    }
}
