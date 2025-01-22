using System;
using UnityEngine;

// 플래그가 enum 데이터형을 중복해서 선택할수 있게 해줌
[Flags]
public enum DAY
{
    None = 0,
    Sun = 1 << 0, // 숫자 1에서 0칸 이동하세요
    Mon = 1 << 1, // 숫자 1에서 1칸 이동하세요 , 이진수 기준으로 2가됨
    Tue = 1 << 2, // 숫자 1에서 2칸 이동하므로 2^2 =4 가됨 . 마치 비트이동
    Wed = 1 << 3,
    Thu = 1 << 4,
    Fri = 1 << 5,
    Sat = 1 << 6  // 비트연산으로 표시하면 유니티 에디터에서 중복선택이 시각적으로 표시됨
}

public enum JOB
{
    직장인, 프리랜서
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

        Debug.Log($"일하는 요일은 {workDay}");
        Debug.Log($"직업은 {jOB}입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
