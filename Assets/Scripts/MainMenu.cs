using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Level 1");

    }//end playGameFunction

    public void QuitGame(){
        Debug.Log($"Game Ended");
        Application.Quit();
    }//end Quit Game

}//end class
