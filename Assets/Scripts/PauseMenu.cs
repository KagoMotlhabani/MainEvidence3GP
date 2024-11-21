using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

/*
Note:
This is the same script that I used for my CPAs in Game Production 1
-Kago
*/

//Testing Github

public class PauseMenu : MonoBehaviour
{
    public bool paused = false;
    public GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log($"Escape pressed");
            Pause();
        }

    }//end update

    public void Pause()
    {
        if (!paused) //if not paused, pasue the game and bring up the menu
        {
            pauseMenu.SetActive(true);
            paused = true;
            Time.timeScale = 0;
        }
        else //if paused, resume the game and deactivate the menu
        {
            pauseMenu.SetActive(false);
            paused = false;
            Time.timeScale = 1;
        }
    }//end Pause

    public void Resume(){
        pauseMenu.SetActive(false);
        paused = false;
        Time.timeScale = 1;

    }//end Resume

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }//end MainMenu

    public void QuitGame()
    {
        Debug.Log("GAME ENDED");
        Application.Quit();
    }
}//end class