using UnityEngine;
using System.Collections.Generic;

[AddComponentMenu("HyunJun/homework")]
public class homework : MonoBehaviour
{
    // ���� ���ɿ���
    public bool JumpPossible = true; // jump 
    // ���Ϲٱ���
    public List<string> fruitBasket = 
            new List<string> {"Apple","Banana", "Orange"};
        
    // money
    public float money = 27f;
    // �ʵ� ��
    [Range(1, 99)] 
    public int fieldOfView;
    // rainbow Color[] rainbowColors
    public Color[] rainbowColors =
            new Color[]
            {
                Color.red,
                new Color(1.0f, 0.5f, 0.0f),
                Color.yellow,
                Color.green,
                Color.blue,
                new Color(0.2f, 0.0f, 1.0f),
                new Color(0.56f, 0.0f, 1.0f),
            };

    // ������ �����
    public int segments = 75; // ��ġ ���׸�Ʈ ��
    public float radius = 5.0f; // ������ ������

    void Start()
    {
        // �ʱ�ȭ�� �����͸� Ȯ���ϱ� ���� ����� ���
        Debug.Log($"Can Jump: {JumpPossible}");
        Debug.Log($"Fruit Basket: {string.Join(", ", fruitBasket)}");
        Debug.Log($"Money: ${money}");
        Debug.Log($"Field of View: {fieldOfView}");
        Debug.Log($"Rainbow Colors: {rainbowColors.Length} colors defined");


        // ������ �����
        for (int i = 0; i < rainbowColors.Length; i++)
        {
            // LineRenderer ����
            GameObject lineObject = new GameObject($"RainbowArch_{i}");
            LineRenderer lineRenderer = lineObject.AddComponent<LineRenderer>();

            lineRenderer.positionCount = segments + 1;
            lineRenderer.widthMultiplier = 0.2f;
            lineRenderer.material = new Material(Shader.Find("Sprites/Default")); // �⺻ ���̴�
            lineRenderer.startColor = rainbowColors[i];
            lineRenderer.endColor = rainbowColors[i];

            // �׶��̼� ����
            Gradient gradient = new Gradient();
            gradient.SetKeys(
                new GradientColorKey[]
                {
                    new GradientColorKey(rainbowColors[i], 0.0f), // ���� ����
                    new GradientColorKey(rainbowColors[i], 1.0f)  // �� ����
                },
                new GradientAlphaKey[]
                {
                    new GradientAlphaKey(0.2f, 0.0f), // ���� ���� (0%)
                    new GradientAlphaKey(1.0f, 0.5f), // �߰� ���� (100%)
                    new GradientAlphaKey(0.2f, 1.0f)  // �� ���� (0%)
                }
            );
            
            lineRenderer.colorGradient = gradient;


            // ��ġ ���
            float currentRadius = radius - (i * 0.2f); // �� ���󸶴� �������� ����
            for (int j = 0; j <= segments; j++)
            {
                float angle = Mathf.PI * (j / (float)segments); // 0���� PI������ ����
                float x = Mathf.Cos(angle) * currentRadius;
                float y = Mathf.Sin(angle) * currentRadius;

                lineRenderer.SetPosition(j, new Vector3(x, y, 0));
            }
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
