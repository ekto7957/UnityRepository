using System;
using UnityEngine;

// �÷��װ� enum ���������� �ߺ��ؼ� �����Ҽ� �ְ� ����
[Flags]
public enum DAY
{
    None = 0,
    Sun = 1 << 0, // ���� 1���� 0ĭ �̵��ϼ���
    Mon = 1 << 1, // ���� 1���� 1ĭ �̵��ϼ��� , ������ �������� 2����
    Tue = 1 << 2, // ���� 1���� 2ĭ �̵��ϹǷ� 2^2 =4 ���� . ��ġ ��Ʈ�̵�
    Wed = 1 << 3,
    Thu = 1 << 4,
    Fri = 1 << 5,
    Sat = 1 << 6  // ��Ʈ�������� ǥ���ϸ� ����Ƽ �����Ϳ��� �ߺ������� �ð������� ǥ�õ�
}

public enum JOB
{
    ������, ��������
}
public class test3 : MonoBehaviour
{

    public string[] schedules;
    public DAY workDay;
    public JOB jOB;














    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i=0; i < schedules.Length;i++)
        {
            Debug.Log(schedules[i]);
        }

        Debug.Log($"���ϴ� ������ {workDay}");
        Debug.Log($"������ {jOB}�Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
