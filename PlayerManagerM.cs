using UnityEngine;
using System.Collections;

public class PlayerManagerM : MonoBehaviour
{
    public float speedX;
    public float jumpSpeedY;
    public float delayBeforeDubleJump;
    public GameObject skillOneLeft, skillOneRight;
    public GameObject skill2Left, skill2Right;
    public float CooldownSkillOne;
    public float CDcountdown;
    bool facingRight, jumping, isGrounded, canDubleJump;
    float speed;

    
    

    Transform skillPosition;
    Transform skillPosition2;

    
    Animator sharlotte;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        sharlotte = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
        skillPosition = transform.FindChild("skillPosition");
        skillPosition2 = transform.FindChild("skillPosition");
        CDcountdown = 0;    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CDcountdown>0)
        {
            CDcountdown -= Time.deltaTime;
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
            isGrounded = true;
            canDubleJump = false;
            jumping = false;
            sharlotte.SetInteger("state", 0);
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

        if (rb.velocity.y < 0f)
        {

            sharlotte.SetInteger("state", 9);
        }




    



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

    // animation and flip the skillOne direction
    void skillOne()
    {
        if (CDcountdown <= 0)
        {


            sharlotte.Play("AsAskill1");

            if (facingRight)

                Instantiate(skillOneRight, skillPosition.position, Quaternion.identity);

            if (!facingRight)



                Instantiate(skillOneLeft, skillPosition.position, Quaternion.identity);
            CDcountdown = CooldownSkillOne;
        }
        
        

    }
    
     public void skill1()
    {
        skillOne();

    }

    // animation and flip skill2 direction
    void skill2()
    {

        

            sharlotte.Play("AsAskill2");

            if (facingRight)

                Instantiate(skill2Right, skillPosition2.position, Quaternion.identity);

            if (!facingRight)

                Instantiate(skill2Left, skillPosition2.position, Quaternion.identity);
        
    }

    public void skill22()
    {
        

        skill2();

    }

    //MovingPlatfor collider2d with 

    void OnCollisionEnter2D(Collider2D other)
    {

        if (other.transform.tag == "mc")
        {
            transform.parent = other.transform;


        }

    }

        void OnCollisionExit2D(Collider2D other)
    {

            if (other.transform.tag == "mc")
            {
                transform.parent = null;


            }
        }



}
