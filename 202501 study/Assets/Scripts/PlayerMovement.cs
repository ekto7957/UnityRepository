using Unity.VisualScripting;
using UnityEngine;
// player moving by rigidbody
// class = component
// ������ �ٵ� ������ �����ϴ� �ڵ� -> ������ٵ� ���� �Ұ� , ���� object �� ��ũ��Ʈ ������ ������ �ٵ�� �ڵ����� ��������
//
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public int a = 10;
    
    public float speed = 2.0f; // float data -> 1.0f , up to 6th

    public float jumpForce; // -<double data has no f , up to 15th

    public bool isGrounded;

    private Rigidbody2D rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        rigid = GetComponent<Rigidbody2D>();
        // GetComponent<T> , getting rigidbody's component , put type of component in T 
        // if type is not same , error occurs
        // if data doesnt exist , GetComponent<T> return NULL!


    }

    // Update is called once per frame
    void Update()
    {
        // Move
        Move();
        Jump();
    }

    private void Move()
    {
       // Ű����
       // �̵� , ��ǥ���ͷ� ǥ����
       // input Ŭ�������� ����Ƽ ��ǲ�Ŵ������� �����Ǿ��ִ� �̵����� ������Ʈ ��������
       float x = Input.GetAxisRaw("Horizontal");
       float y = Input.GetAxisRaw("Vertical");
       // GetAxisRaw("Ű�̸�"); get input manager's key
       // Ŭ���� ���� -1 0 1�� ��ġ���� ���´�
       //"Horizontal" : �����̵� , a / d -> <-
       // "Vertical"  : w,s 

       Vector3 velocity = new Vector3(x, y, 0) * speed * Time.deltaTime;
       transform.position += velocity;


    }

    private void Jump()
    {
        // space �Է½� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded) // !isJumping
            {
                isGrounded = false;
                rigid.AddForceY(jumpForce, ForceMode2D.Impulse);
                //rigid.AddForce(Vector3.up * (float)jumpForce, ForceMode2D.Impulse) // type casting ex) int -> float
            }
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("������ �ֿ���!");

            // �ش� ������Ʈ�� ��Ȱ��ȭ
            collision.gameObject.SetActive(false);
        }
    }
    // ���� ��������� �����ؾ� �ٽ� jump�Ҽ��ִ�.

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // == -> ������ != -> �ٸ���
        if(collision.gameObject.layer == 7) // tag�� ���ڿ� "" �� ���� layer�� ����Ƽ�����ͳ����� ����� �ο��� ��ȣ ������
        isGrounded = true;
        Debug.Log($"your ground state is {isGrounded}!");
    }

}
