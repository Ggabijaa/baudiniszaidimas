using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private Animator animator;
    [SerializeField]private Transform groundCheckCollider;
    [SerializeField]private LayerMask groundLayer;
    private float horizontalValue;
    public float speed = 1;
    [SerializeField] private float jumpPower = 100;
    private const float groundCheckRadius = 0.2f;
    private float runSpeedModifier = 2f;
    private bool isRunning = false;
    private bool jump = false;
    [SerializeField] private bool isGrounded = false;
    private bool facingRight = false; // true jei pradzioj ziuri i desine
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // ar liecia zeme
    void GroundCheck()
    {
        isGrounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius,groundLayer);
        if (colliders.Length > 0)
        {
            isGrounded = true;
        }
    }
   
    void Update()
    {
		
        horizontalValue = Input.GetAxisRaw("Horizontal");
		animator.SetFloat("speed",Mathf.Abs(horizontalValue));
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRunning = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
			animator.SetBool("Jumping",true);
            jump = true;
        }
        else if (Input.GetButtonUp("Jump"))
        {
			animator.SetBool("Jumping",false);
            jump = false;
        }
    }

    void FixedUpdate()
    {
        GroundCheck();
        Move(horizontalValue, jump);
    }

    void Move(float dir, bool jumpFlag)
    {
        if (isGrounded && jumpFlag)
        {
            isGrounded = false;
            jumpFlag = false;
            rb.AddForce(new Vector2(0f, jumpPower));
        }
        #region move and run
        // vaiksciojimas
        float xVal = dir *100* speed * Time.fixedDeltaTime;
        if (isRunning)
        {
            xVal *= runSpeedModifier;
        }
        Vector2 targetVelocity = new Vector2(xVal,rb.velocity.y);
        rb.velocity = targetVelocity;
        // atsisukti i ejimo puse
        /*Vector3 currentScale = transform.localScale;
        if (facingRight && dir < 0)
        {
            currentScale.x = -1;
            facingRight = false;
        }
        else if (!facingRight && dir > 0)
        {
            currentScale.x = 1;
            facingRight = true;
        }
        currentScale = transform.localScale;    */
        // sitas neveiktu jei vektorius kistu
        if (facingRight && dir < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            facingRight = false;
        }
        else if (!facingRight && dir > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            facingRight = true;
        }

        // stovi 0 eina 2 bega 4
        //animator.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));
        #endregion
    }
}
