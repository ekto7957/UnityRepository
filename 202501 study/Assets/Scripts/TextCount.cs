using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class TextCount : MonoBehaviour
{
    // �ؽ�Ʈ�� ī��Ʈ�� ����ϴ� ��� ����
    // ī��Ʈ�� �ʸ��� ��� 1�� �����ϴ� ���·� ó��

    public Text countText;
    private int count;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine("IEnumrator������ �Լ� �̸��� ���ڿ� ���·� �Լ���ã�Ƽ� ȣ��");
        StartCoroutine("CountPlus"); // ���ڿ� , ���ڿ��� ����� �ڷ�ƾ�� ���ߴ� ���� �������� ����Ҽ� ����
        StopCoroutine("CountPlus");

        //StartCoroutine(�Լ����̸�());
        //�ش��Լ��� ȣ���� �������� ��ȯ�޴� ���� -> ��Ÿ �߻��� ����üũ ����
        // StopCoroutine ���Ἥ ������ų���� ����
        StartCoroutine(CountPlus()); // �Լ��� ȣ���ؼ� �����ϴ� ��� , �������� ����� �ȵ����� ���� �����Ҽ��ִ�??
    }

    // �ڸ�ƾ�� �����Ӵ����� ��ħ�� �����ִ� ����̶� ������Ʈ �Լ� �Ⱦ���.
    IEnumerator CountPlus()
    {
        while (true)
        {
            count++;
            countText.text = count.ToString("N0"); // N0 : 3�ڸ����� ��ǥ
            yield return null; // move next frame

/*        Debug.Log("mic test over!");
        yield return new WaitForSeconds(1);
        //yield�� �Ͻ������� �������� ������ �ٸ��Լ��� �����ϴ� Ű����
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
