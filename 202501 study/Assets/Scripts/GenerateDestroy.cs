using UnityEngine;

public class GenerateDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject prefab;
    private GameObject bomb;
    void Start()
    {
        bomb = Instantiate(prefab);
        Debug.Log("activate bomb.");
        Destroy(bomb, 5.0f);
        Debug.Log("bomba!!.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
