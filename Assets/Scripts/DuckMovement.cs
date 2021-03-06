using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private UIInventory uIInventory;
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;
    private float endPosition;
    private Inventory inventory;



    public static bool PlayerControlsDisabled = false;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        endPosition = GameObject.Find("End Flag").transform.position.x;
        inventory = new Inventory();
        uIInventory.SetInventory(inventory);
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

        cantMoveOverEndFlag();
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

    private void cantMoveOverEndFlag()
    {
        if (transform.position.x < endPosition)
        {
            body.velocity = new Vector2(speed, body.velocity.y);
        }
    }

    public void useItem(Item item)
    {
        inventory.useItem(item);
        refreshUI();
    }

    public void pickItem(Item item)
    {
        inventory.addItem(item);
        refreshUI();
    }

    public void refreshUI()
    {
        uIInventory.SetInventory(inventory);
    }


}
