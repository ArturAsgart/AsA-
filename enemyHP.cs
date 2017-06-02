using UnityEngine;
using System.Collections;


public class enemyHP : MonoBehaviour
{


    public int maxHealth = 100;
    public float healthBarLength;

    public int curHealth = 100;
    //



    // public MyHP playerHealth;
    // Use this for initialization 
    void Start()
    {

       
       
    }

    // Update is called once per frame 
    void Update()
    {

        if (curHealth <= 0)
        {
            //spawn
            GameObject.Find(gameObject.name + ("spawn point")).GetComponent<respoint>().Death = true;
            //Then destroy it
            Destroy(gameObject);

        }




        AdjustCurrentHealth(0);

        if (curHealth == 0)
        {
            Destroy(gameObject);
        }

    }

    void OnGUI()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "littlebullet" || collision.gameObject.tag == "bigbullet")
        {
            AdjustCurrentHealth(-10);

        }





    }
    public void takeeDMG(int dmg)
    {
        Debug.Log(dmg);
        curHealth -= dmg;



    }
    public void AdjustCurrentHealth(int adj)
    {
        curHealth += adj;

        if (curHealth < 0)
            curHealth = 0;

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (maxHealth < 1)
            maxHealth = 1;




    }


}

     



    


