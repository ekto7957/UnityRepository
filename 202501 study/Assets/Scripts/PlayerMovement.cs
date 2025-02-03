using Unity.VisualScripting;
using UnityEngine;
// player moving by rigidbody
// class = component
// 리지드 바디 쓰도록 강제하는 코드 -> 리지드바디 삭제 불가 , 없는 object 에 스크립트 넣으면 리지드 바디와 자동으로 연결해줌
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
       // 키설정
       // 이동 , 좌표벡터로 표시함
       // input 클래스에서 유니티 인풋매니저에서 설정되어있는 이동관련 컴포넌트 가져오기
       float x = Input.GetAxisRaw("Horizontal");
       float y = Input.GetAxisRaw("Vertical");
       // GetAxisRaw("키이름"); get input manager's key
       // 클릭에 따라 -1 0 1의 수치값을 얻어온다
       //"Horizontal" : 수평이동 , a / d -> <-
       // "Vertical"  : w,s 

       Vector3 velocity = new Vector3(x, y, 0) * speed * Time.deltaTime;
       transform.position += velocity;


    }

    private void Jump()
    {
        // space 입력시 점프
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
            Debug.Log("코인을 주웠다!");

            // 해당 오브젝트를 비활성화
            collision.gameObject.SetActive(false);
        }
    }
    // 땅에 닿았을떄를 구현해야 다시 jump할수있다.

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // == -> 같으면 != -> 다르면
        if(collision.gameObject.layer == 7) // tag는 문자열 "" 로 적고 layer는 유니티에디터내에서 만들고 부여한 번호 기준임
        isGrounded = true;
        Debug.Log($"your ground state is {isGrounded}!");
    }

}
