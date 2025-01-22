using UnityEngine;
/// <summary>
/// class for rotationg cube object
/// </summary>

public class CubeRotate : MonoBehaviour
{
    // Ʈ�������̶�� Ŭ������ ã�Ƽ� rotation�� ���õ� ������Ʈ�� �����غ���.
    // public���� �����ϸ� ����Ƽȭ��� �ν����� â���� ã���� �ִٴ� ���̴�.

    #region data type summary
    // �ڷ��� Ÿ��
    // int ����
    // float �Ǽ�
    // bool True or false ��ȯ�� -> if�� ������� �ȵ��� �������ټ���3
    // string ��������
    // ��ǻ�Ͱ� �������� Ÿ���� �Ǵ��ϴ� ����
    #endregion


    #region variable
    // �����Ǽ��� -> data type�� �����ϰ� �������� �Է��ϸ� �����͸� �����ϱ� ���� ��������
    [Header("setting")]
    
    public float x; // ����Ƽ �����Ϳ��� ������
    public float z;

    private int sample; // ����Ƽ���� ������ �ȵǴ� ����
    #endregion

    

    void Start()
    {
        sample = 10;
        Debug.Log(sample);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x * Time.deltaTime, 0, z * Time.deltaTime));
        // ����3�� ����Ƽ�������� �ϳ��� �ڷ��� , ���Ͱ� 0�� ȸ���ϰ� ���� �ʴ� ��� �ؼ��Ҽ�����
        // deltaTime�� ���� : �� �����ӿ� �ҿ�Ǵ� �����ð� , fps = �ʴ� ������
    }
}
