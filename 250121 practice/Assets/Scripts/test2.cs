using UnityEngine;

/// <summary>
/// unity attribute
/// 에디터에 맞춤으로 스크립트 커스텀마이즈
/// 문장 등의 여러가지 꾸며주는 요소들
/// </summary>

// 스크립트를 그룹화 해보기
// add components에 해당 스크립트가 뜬다!

[AddComponentMenu("CustomUtility/test2")]
public class test2 : MonoBehaviour
{
    [Range(1, 99)]
    public int level;
    
    [Range(0, 100)]
    public int volume;

    [Header("Profile")]
    public string playerName;
    public string playerDescription;

    [TextArea] 
    public string talk01;

    [TextArea(1,3)]
    public string talk02;

    [TextArea(5,7)]
    public string talk03;

    [Tooltip("if this component is checked, you are dead now")]
    public bool isDead = true ;

    /// <summary> 함수
    /// 
    /// 보이드 아닌거 - 다른곳에 전달 , 보이드 - 기능
    /// 함수 function 
    /// C#에서는 클래스 내부에서 설계되는 함수를 method라고 부른다
    /// 함수는 특정 기능을 수행하기 위해 작성된 명령문 집합체, 코드 내에서 설계된 함수는 원하는 작업 위치에서 호출해서 사용가능
    /// 함수 설계법
    /// 자료형 함수이름(매개변수){
    ///     함수 호출시 실행할 명령들
    /// }
    ///
    /// 함수 호출법
    /// 함수이름(인자);
    ///
    /// 매개변수 : 함수호출시 전달받을 데이터
    /// 인자 : 함수 호출시 전달할 값
    /// 
    /// </summary>
    [ContextMenu("HelloEveryone")]

    void HelloEveryone()
    {
        Debug.Log("여러분 안녕하세요");
    }

    void HelloSomeone(string who)
    {
        Debug.Log($"{who}님 안녕하세요");
    }


    void Start()
    {
        HelloEveryone();
        HelloSomeone("hyunjun");
    }
    void Update()
    {

    }
    
}