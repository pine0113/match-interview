using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;
    private float endPosition;

    public static bool PlayerControlsDisabled = false;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        endPosition = GameObject.Find("End Flag").transform.position.x;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if (!PlayerControlsDisabled) {

            if (horizontalInput > 0.01f)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (horizontalInput < -0.01f)
            {
                transform.localScale = Vector3.one;
            }

            if (Input.GetKey(KeyCode.Space) && grounded)
                Jump();

        

            anim.SetBool("run", (horizontalInput !=0) );
            anim.SetBool("grounded", grounded);
        }

        if (transform.position.x < endPosition)
        {
            body.velocity = new Vector2( Mathf.Abs((horizontalInput * speed)), body.velocity.y);
        }
    }
   


    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }
    
}
