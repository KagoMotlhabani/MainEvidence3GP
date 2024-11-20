using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Attach this script to the Goal Game Object and change the level label

public class LevelLoader : MonoBehaviour
{

    //Audio Stuff too..



    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            SceneManager.LoadScene("Level 3");
        }
    }
}//end class
