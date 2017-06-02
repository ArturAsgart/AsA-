using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
          public void loadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;



    }
	
    public void ClickExit()
    {
        



      //  UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();

    }

}
