using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Note:
This is the same script that I used for my CPAs in Game Production 1
-Kago
*/

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
            Pause();
        }

    }//end update

    public void Pause()
    {
        if (!paused) //if not paused, pasue the game and bring up the menu
        {
            pauseMenu.SetActive(true);
            paused = true;
        }
        else //if paused, resume the game and deactivate the menu
        {
            pauseMenu.SetActive(false);
            paused = false;
        }
    }//end loadscene

    public void QuitGame()
    {
        Debug.Log("GAME ENDED");
        Application.Quit();
    }
}//end class