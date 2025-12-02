using UnityEngine;
using UnityEngine.InputSystem.DualShock;

public class Player : MonoBehaviour

{
    [field: SerializeField] private float moveSpeed = 5f;

    [field: SerializeField] private bool isInvulenrable = false;
    private float jumpForce = 10f;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void SetMoveSpeed(float newSpeed)
    {
        newSpeed = 5f;
        Debug.Log("Speed Changed");
    }

    public void SetInvulinerability(bool isEnabled)
    {
        Debug.Log("Player is immune");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}