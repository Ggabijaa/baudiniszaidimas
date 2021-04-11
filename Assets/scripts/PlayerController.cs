using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Animator animator;
    public float Speed = 6f;
    public float RuningSpeed = 12f;
    private float Speed2 = 0f;

    public float Jump = 2f;
    private int jumped = 1;

    private Rigidbody2D _rigidbody2D;
    private bool facingRight = false;

	public int Max = 100;
	public static int current = 10;
    public HealtBarScript healt;

	private AudioSource footstep;
    // Start is called before the first frame update
   
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        footstep = GetComponent<AudioSource>();
		current = Max;
		healt.setMaxHealth(Max);
    }

    // Update is called once per frame
    void Update()
    {
        if(current >= Max)
		current = Max;
        healt.setHealtd(current);
        
        if (Input.GetButtonDown("Jump") && jumped == 1)
        {
            	SoundManager.PlaySound("Jump");
                _rigidbody2D.AddForce(new Vector2(0, Jump), ForceMode2D.Impulse);
                animator.SetBool("Jump", true);
                jumped++;
            
        }
        if (Mathf.Abs(_rigidbody2D.velocity.y) < 0.001f)
        {
            jumped = 1;
            animator.SetBool("Jump", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed2 = RuningSpeed;
            animator.SetBool("Runing", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed2 = Speed;
            animator.SetBool("Runing", false);
        }

        move(Speed2);
    }
	private void Footstep()
    {
        footstep.Play();
    }
    private void move(float speed)
    {
        float horizontalValue= Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Walking",Mathf.Abs(horizontalValue));
        var move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move, 0, 0) * Time.deltaTime * speed;
        
        
        
        
        if (facingRight && horizontalValue > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            facingRight = false;
        }
        else if (!facingRight && horizontalValue < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            facingRight = true;
        }
    }
}
