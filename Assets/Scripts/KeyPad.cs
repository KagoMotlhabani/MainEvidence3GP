using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class KeyPad : MonoBehaviour
{
    //attached to door
    [SerializeField] public TMP_Text Ans;
    public string Answer = "488";// order: blue, green, red
    public string currentInput;
    public Door door;
    public GameObject keypad;
    public float toggleDistance = 50f;
    public bool doorObjectV;


     void Start()
    {
       //DoorObject.SetActive(true); 
    }
    // Start is called before the first frame update
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    // Update is called once per frame
    public void Enter()
    {
        currentInput = Ans.text;
        Debug.Log($"Current input is: " + currentInput);
        if(currentInput== Answer)//if the player answer is correvt
        {
            Ans.text = "Correct";
            Debug.Log($"Correct, open door");
            door.OpenDoor();
/*
            if (!doorObjectV)
            {
                Vector3 playerPosition = transform.position;
                Vector3 objectPosition = DoorObject.transform.position;
                float distance = Vector3.Distance(playerPosition, objectPosition);

                if (distance <= toggleDistance)
                {
                    doorObjectV = false;
                    //DoorObject.SetActive(false);
                }


            }
            */
        } 
       else
        {
            Ans.text = "Invalid";
        }
    }//end enter function
   
}//end class
