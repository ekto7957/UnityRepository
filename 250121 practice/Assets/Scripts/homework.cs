using UnityEngine;
using System.Collections.Generic;

[AddComponentMenu("HyunJun/homework")]
public class homework : MonoBehaviour
{
    // 점프 가능여부
    public bool JumpPossible = true; // jump 
    // 과일바구니
    public List<string> fruitBasket = 
            new List<string> {"Apple","Banana", "Orange"};
        
    // money
    public float money = 27f;
    // 필드 뷰
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

    // 무지개 만들기
    public int segments = 75; // 아치 세그먼트 수
    public float radius = 5.0f; // 무지개 반지름

    void Start()
    {
        // 초기화된 데이터를 확인하기 위한 디버그 출력
        Debug.Log($"Can Jump: {JumpPossible}");
        Debug.Log($"Fruit Basket: {string.Join(", ", fruitBasket)}");
        Debug.Log($"Money: ${money}");
        Debug.Log($"Field of View: {fieldOfView}");
        Debug.Log($"Rainbow Colors: {rainbowColors.Length} colors defined");


        // 무지개 만들기
        for (int i = 0; i < rainbowColors.Length; i++)
        {
            // LineRenderer 생성
            GameObject lineObject = new GameObject($"RainbowArch_{i}");
            LineRenderer lineRenderer = lineObject.AddComponent<LineRenderer>();

            lineRenderer.positionCount = segments + 1;
            lineRenderer.widthMultiplier = 0.2f;
            lineRenderer.material = new Material(Shader.Find("Sprites/Default")); // 기본 셰이더
            lineRenderer.startColor = rainbowColors[i];
            lineRenderer.endColor = rainbowColors[i];

            // 그라데이션 적용
            Gradient gradient = new Gradient();
            gradient.SetKeys(
                new GradientColorKey[]
                {
                    new GradientColorKey(rainbowColors[i], 0.0f), // 시작 색상
                    new GradientColorKey(rainbowColors[i], 1.0f)  // 끝 색상
                },
                new GradientAlphaKey[]
                {
                    new GradientAlphaKey(0.2f, 0.0f), // 시작 투명도 (0%)
                    new GradientAlphaKey(1.0f, 0.5f), // 중간 투명도 (100%)
                    new GradientAlphaKey(0.2f, 1.0f)  // 끝 투명도 (0%)
                }
            );
            
            lineRenderer.colorGradient = gradient;


            // 아치 계산
            float currentRadius = radius - (i * 0.2f); // 각 색상마다 반지름을 줄임
            for (int j = 0; j <= segments; j++)
            {
                float angle = Mathf.PI * (j / (float)segments); // 0부터 PI까지의 각도
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
