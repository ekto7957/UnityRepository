using UnityEngine;
using Assets.Sprites;

// using ---- �� "������ ���� ���� �ڵ忡�� ����ϴ� ���̴�" �� �ǹ��Դϴ�.
// ����Ʈ ������ Ȱ���ϴ� ��ũ��Ʈ�� ���� �ڵ带 �ݵ�� �߰��ϼ���.

// namespace�� ������ ������ �������, �̸������Ҷ� �����ؾ��� ������ �ִ°͵�� �浹 ���ɼ�
// Ư�� ����� �ϴ� Ŭ������ ��ǥ �̸����� ���˴ϴ�.� ���� Ȥ�� ������Ʈ�� ���Ǵ� Ŭ�������� �ľǰ���
namespace UnityTutorial2
{
    // ����Ƽ Ʃ�丮���̶�� ������ ����� �׾ȿ� ����A Ŭ������ ����
    public class SampleA
    {

    }
}
// Ŭ���� ���� �ٽö� Ŭ���� �����ص� �Ǵµ� monobehaviour �� �� �������� ����
public class SampleA
{

}

/// <summary>
/// ó������ ���� ����Ƽ�� ��ũ��Ʈ
/// </summary>

public class test : MonoBehaviour
{
    // MonoBehaviour�� Ŭ������ �������� ���
    // ����Ƽ ���� �����ϴ� ������Ʈ�� ��ũ��Ʈ�� �����Ҽ� �ְ� ����
    // test�� Ŭ���� ���� , �̰��� ����Ƽ���� �����ϴ� ����� ������Ʈ�� ������

    // Assets.Sprites.NewBehaviourScript1 �̷������� ���� �ҷ��ü� �ִ�.
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    /// <summary>
    /// ���� ��� �Լ� ����
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

    private float timeElapsed = 0f; // ��� �ð� ����
    public float interval = 1f; // ��� ���� (��)

    void Update()
    {
        timeElapsed += Time.deltaTime; // ������ �� ��� �ð� �߰�

        if (timeElapsed >= interval)
        {
            Debug.Log("�ȳ�! �ȳ�! �ȳ�!");
            Debug.Log($"{count}");
            count++;
            timeElapsed = 0f;
        }
    }
}
