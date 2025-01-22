using UnityEngine;

/// <summary>
/// unity attribute
/// �����Ϳ� �������� ��ũ��Ʈ Ŀ���Ҹ�����
/// ���� ���� �������� �ٸ��ִ� ��ҵ�
/// </summary>

// ��ũ��Ʈ�� �׷�ȭ �غ���
// add components�� �ش� ��ũ��Ʈ�� ���!

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

    /// <summary> �Լ�
    /// 
    /// ���̵� �ƴѰ� - �ٸ����� ���� , ���̵� - ���
    /// �Լ� function 
    /// C#������ Ŭ���� ���ο��� ����Ǵ� �Լ��� method��� �θ���
    /// �Լ��� Ư�� ����� �����ϱ� ���� �ۼ��� ��ɹ� ����ü, �ڵ� ������ ����� �Լ��� ���ϴ� �۾� ��ġ���� ȣ���ؼ� ��밡��
    /// �Լ� �����
    /// �ڷ��� �Լ��̸�(�Ű�����){
    ///     �Լ� ȣ��� ������ ��ɵ�
    /// }
    ///
    /// �Լ� ȣ���
    /// �Լ��̸�(����);
    ///
    /// �Ű����� : �Լ�ȣ��� ���޹��� ������
    /// ���� : �Լ� ȣ��� ������ ��
    /// 
    /// </summary>
    [ContextMenu("HelloEveryone")]

    void HelloEveryone()
    {
        Debug.Log("������ �ȳ��ϼ���");
    }

    void HelloSomeone(string who)
    {
        Debug.Log($"{who}�� �ȳ��ϼ���");
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