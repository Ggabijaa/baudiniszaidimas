using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioSource audioScr1;
    private Animator animator;
	
	public static float Score = 0;
	 
	public static float horizontalValue;
    public static float Speed = 6f;
    public float RuningSpeed = 12f;
	public float Speed2 = 0f;

    public static float Jump = 7f;
    private int jumped = 1;

    private Rigidbody2D _rigidbody2D;
    public static bool facingRight = false;
	
	public static int ammo = 10;
	public static int coins = 50;

	public static int Max = 100;
	public static int MaxHealt = 100;

	public static int current = 0;
	public static int currentHealt = 0;

    public HealtBarScript healt;
	public HealtBarScript armor;

	private float time = 0;
	private AudioSource footstep;

	public GameObject Main;
	public GameObject End;
	int times = 8;
	int active = 1;
    // Start is called before the first frame update
   
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
		Time.timeScale = 1f;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        footstep = GetComponent<AudioSource>();
		current = 50;
		currentHealt = 50;
		healt.setMaxHealth(MaxHealt);
		armor.setMaxHealth(Max);
		armor.setHealtd(current);
    }

    // Update is called once per frame
    void Update()
    {
		
		time += Time.deltaTime;
		//Debug.Log(time);
        if(current >= Max)
		current = Max;
		if(current < 0)
		current = 0;
        armor.setHealtd(current);
        if(currentHealt >= MaxHealt)
		currentHealt = MaxHealt;
		if(current < 0)
		currentHealt = 0;
		healt.setHealtd(currentHealt);
		if(currentHealt==0 && active == 1)
		{
			
			if(times > 0)
			{
				
				SoundManager.PlaySound("nos");	
				times-=1;
			}
			audioScr1.Stop();
			Time.timeScale = 0f;
            Score = time;
			Main.SetActive(false);
			End.SetActive(true);
active +=1;
		}
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
		Speed2 = Speed;
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
        horizontalValue= Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Walking",Mathf.Abs(horizontalValue));
        var move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move, 0, 0) * Time.deltaTime * speed;
        
        
        // Debug.Log(horizontalValue);
        
        if (facingRight && horizontalValue > 0)
        {
			
			//transform.Rotate(0f,180f,0f);
            transform.localScale = new Vector3(1, 1, 1);
            facingRight = false;
        }
        else if (!facingRight && horizontalValue < 0)
        {
 			
			//transform.Rotate (0f ,180f , 0f);
            transform.localScale = new Vector3(-1, 1, 1);
            facingRight = true;
        }
    }

}
