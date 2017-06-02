using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Artifacts : MonoBehaviour
{
    public static int score;
    public float win;
    public Texture2D textureToDisplay;
    GUIStyle largeFont;
    Text text;

   
    

        void Start()

    {
        largeFont = new GUIStyle();
        largeFont.fontSize = 80;

        text = GetComponent<Text>();

        score = 0;
    }


    void Update()
    {

        if (score < 0)
            score = 0;

        text.text = "" + score;

  /*     if(score  == 1)
        {
            Debug.Log("dd");
            OnGUI();
        }
*/
    }


    public static void AddPoints  ( int pointsToAdd)
    {

        score += pointsToAdd;


    }


    public static void Reset()
    {

        score = 0;

    }


    void OnGUI()
    {
        if (score == 12)
        {
            Debug.Log("dd");
            GUI.Label(new Rect(300, 300, 300, 2000), "YOU WIN", largeFont);
            Time.timeScale = 0f;
         
           
            Application.LoadLevel("win");


        }

    }

}
