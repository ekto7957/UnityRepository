using UnityEngine;



[AddComponentMenu("hyunjun/sample1")]
public class homeworksolution : MonoBehaviour
{

    public bool canJump;
    public string[] fruitBasket = new[] { "apple", "banana" };
    public int money;
    [Range(1, 99)] public int fView;
    // rainbow 7���� ���� ���������̹Ƿ� enum���� ¥�� ������.
    // ������ ������ �ߺ��� �ʿ�� ��� flag �� �ʿ����
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
