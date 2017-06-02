using UnityEngine;
using System.Collections;

public class PlayerManagerM : MonoBehaviour
{
    public float speedX;
    public float jumpSpeedY;
    public float delayBeforeDubleJump;

    public GameObject skillOneLeft, skillOneRight;
    public GameObject skill2Left, skill2Right;
    //CD on Skill one 
    public float CooldownSkillOne;
    //TIME COUNTER
    public float CDcountdownSkillOne;
    // CD on skill 2
    public float CooldownSkill2;
    // TIME COUNTER 2
    public float CDcountdownSkill2;



    //timer on falling animation (killing bug falling )
    public float ColldownFalling;
    public float CDcounterFalling;


    // Other
    public bool facingRight, jumping, isGrounded, canDubleJump;
    float speed;

    
    

    Transform skillPosition;
    Transform skillPosition2;

    
    Animator sharlotte;
    Rigidbody2D rb;


    public AudioClip teleportSound;

    



    // Use this for initialization
    void Start()







    {
       
        sharlotte = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
        skillPosition = transform.FindChild("skillPosition");
        skillPosition2 = transform.FindChild("skillPosition");
        CDcountdownSkillOne = 0;
        CDcountdownSkill2 = 0;
        CDcounterFalling = 0;


    }

    // Update is called once per frame
    void Update()
    {

        
       


        if (CDcountdownSkillOne > 0)
        {
            CDcountdownSkillOne -= Time.deltaTime;
        }


        if (CDcountdownSkill2>0)
        {
            CDcountdownSkill2 -= Time.deltaTime;
        }

        if (CDcounterFalling > 0)
        {
            CDcounterFalling -= Time.deltaTime;
        }

        // player movement
        MovePlayer(speed);



        

        // left player movement
        if (Input.GetKeyDown(KeyCode.LeftArrow))

        {
            speed = -speedX;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {

            speed = 0;
        }
        //

        // right player movement
        if (Input.GetKeyDown(KeyCode.RightArrow))

        {
            speed = speedX;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {

            speed = 0;
        }
        // junm code!!!!!!!!!!!!!

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            jump();
        }


        // duble jump code!!!!!!!!!!!
        if (Input.GetKeyDown(KeyCode.UpArrow) && canDubleJump)
        {
            jump();
        }


        // skill1 
        if (Input.GetKeyDown(KeyCode.S))
        {
            
            skillOne();
            
        }


        // skill2
        if (Input.GetKeyDown(KeyCode.D))
        {

            skill2();

        }


    }


    void OnCollisionEnter2D(Collision2D other)
    {

       
       

        if (other.gameObject.tag == "mc")
        {
            
            transform.parent = other.transform;
            
            isGrounded = true;
            canDubleJump = false;
            jumping = false;
            sharlotte.SetInteger("state", 0);

            //transform.parent = null;

        }




    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "fire")
        {
           // 
        }
    }



    void MovePlayer(float PlayerSpeed)
    {
        // code for player movement



        if (PlayerSpeed < 0 && !jumping && rb.velocity.y == 0f || PlayerSpeed > 0 && !jumping && rb.velocity.y == 0f)

        {

            sharlotte.SetInteger("state", 1);
        }

        if (PlayerSpeed == 0 && !jumping && rb.velocity.y == 0f)
        {

            sharlotte.SetInteger("state", 0);
        }
        // Falling animation  and code
        if (rb.velocity.y < 0f)
            
            if (CDcounterFalling <= 0)
            {

                {
                
                sharlotte.SetInteger("state", 9);
                }
                isGrounded = false;
                CDcounterFalling = ColldownFalling;

            }

        
        //



        rb.velocity = new Vector3(speed, rb.velocity.y, 0);

        // code flip the player direction
        if (speed > 0 && !facingRight || speed < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 temp = transform.localScale;
            temp.x *= -1;
            transform.localScale = temp;
        }
       
    }
       //
   


    public void Walkleft()
    {
        speed = -speedX;
    }



    public void WalkRight()
    {
        speed = speedX;
    }

    public void StopMoving()
    {
        speed = 0;
    }

    public void jump()
    {
        // single jump
        if (isGrounded)
        {
            jumping = true;
            isGrounded = false;
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeedY));
            sharlotte.SetInteger("state", 2);
            Invoke("EnebleDubleJump", delayBeforeDubleJump);
        }

        // duble jump
        if (canDubleJump)
            
        {

            canDubleJump = false;
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeedY));
            sharlotte.SetInteger("state", 2);

        }
    }

    void EnebleDubleJump()
    {

        canDubleJump = true;
    }

    // animation and flip the skillOne direction + CD on skillOne
    void skillOne()
    {
        if (CDcountdownSkillOne <= 0)
        {

           
            sharlotte.Play("AsAskill1");
           
            if (facingRight)

                Instantiate(skillOneRight, skillPosition.position, Quaternion.identity);

            if (!facingRight)



                Instantiate(skillOneLeft, skillPosition.position, Quaternion.identity);
            CDcountdownSkillOne = CooldownSkillOne;
        }
        
        

    }
    
     public void skill1()
    {
        skillOne();

    }

    // animation and flip skill2 direction + CD on skill2 
    void skill2()
    {
        if (CDcountdownSkill2 <= 0)
        {



            sharlotte.Play("AsAskill2");

            if (facingRight)

                Instantiate(skill2Right, skillPosition2.position, Quaternion.identity);

            if (!facingRight)

                Instantiate(skill2Left, skillPosition2.position, Quaternion.identity);
            CDcountdownSkill2 =  CooldownSkill2;

        }
    }

    public void skill22()
    {
        

        skill2();

    }

    //MovingPlatfor collider2d with plyer

    /* 
           void OnCollisionEnter2D(Collider2D other)
            {
           Debug.Log("Player's Parent: ");
           if (gameObject.CompareTag("mc"))
                {
                    //Debug.Log("Player's Parent: ");
                    transform.parent = other.transform;

                }

            }

            /*   void OnCollisionExit2D(Collider2D other)
            {

                  if (other.transform.tag == "MovingPlatform")
                   {
                        transform.parent = null;

                    Debug.Log("Player's Grand parent: " + rb.transform.parent.parent.name);
                }

            }
        */


}
