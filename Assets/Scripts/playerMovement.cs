using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public Animator an;
    public GameObject Torch;

    public float moveSpeed = 6.0f;
    public float movement = 0.0f;
    public float jumpForce = 1.0f;
    public bool isGrounded = false;
    public float yVelocity;

    private bool dead = false;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            isGrounded = true;
        }
    }

    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
        an.SetFloat("Speed_Hori", Mathf.Abs(movement));
        yVelocity = rb.velocity.y;
        an.SetFloat("Speed_Vert", yVelocity);

        if (movement > 0)
        {
            sr.flipX = false;
        }
        else if (movement < 0)
        {
            sr.flipX = true;
        }

        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveSpeed;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
}