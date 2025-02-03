using UnityEngine;



[AddComponentMenu("hyunjun/sample1")]
public class homeworksolution : MonoBehaviour
{

    public bool canJump;
    public string[] fruitBasket = new[] { "apple", "banana" };
    public int money;
    [Range(1, 99)] public int fView;
    // rainbow 7가지 색은 정해진것이므로 enum으로 짜도 괜찮다.
    // 선택이 여러개 중복할 필요는 없어서 flag 쓸 필요없음
    public enum rainbowColors
    {
        RED, ORANGE, YELLOW,GREEN, BLUE, INDIGO, VIOLET
    }

    public rainbowColors Rainbow;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
