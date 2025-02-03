using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypeTest : MonoBehaviour
{
    public Text message; // type text

    [SerializeField] [TextArea] private string content; // ȭ�鿡 ��½�Ű�� ���� �ν����� â���� �Է��� ����
    [SerializeField] private float delay = 0.2f; // 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnMessageButtonClick()
    {
        StartCoroutine("Typing");
     
    }

    public void ByTwo()
    {
        if (delay == 0.2f)
            delay = 0.1f;
        else
            delay = 0.2f;
    }
    IEnumerator Typing()
    {
        message.text = ""; // ���� ȭ�� �޼��� ����
        int typingCount = 0;
        while (typingCount != content.Length)
        {
            if (typingCount < content.Length)
            {
                message.text += content[typingCount].ToString();
                typingCount++;
            }

            yield return new WaitForSeconds(delay);
        }
      
    }
}
