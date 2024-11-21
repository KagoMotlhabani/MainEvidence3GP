using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//attach this to the player and edit tags approapriately to trigger tutorials

public class TutorialManager : MonoBehaviour
{
    public TMP_Text tutorialText;
    // Start is called before the first frame update
    void Start()
    {
        tutorialText.text = tutorialText.text + "";//put welcome message here
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider tut) {
        if(tut.CompareTag("Blue")){
            tutorialText.text = "Press B to reveal hidden items in this blue area";
        }//end Blue tutorial

        if(tut.CompareTag("Red")){
            tutorialText.text = "Press R to reveal hidden items in this red area";
        }//end Red tutorial

        if(tut.CompareTag("Green")){
            tutorialText.text = "Press G to reveal hidden items in this green area";
        }//end Green tutorial
    }//end on Trigger Enter

    private void OnTriggerExit(Collider tut) {
         if(tut.CompareTag("Blue")){
            tutorialText.text = "";
        }//end Blue tutorial

        if(tut.CompareTag("Red")){
            tutorialText.text = "";
        }//end Red tutorial

        if(tut.CompareTag("Green")){
            tutorialText.text = "";
        }//end Green tutorial
    
        
    }
}//end class
