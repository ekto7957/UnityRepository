using UnityEngine;
using UnityEngine.EventSystems;

public class rightmove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("position of object :" + transform.position);
    }

    public Vector3 MoveDirection = new Vector3(1,0,0);

    public float movespeed = 3f;

    void Update()
    {
        transform.Translate(MoveDirection * movespeed *  Time.deltaTime);
    }
}
