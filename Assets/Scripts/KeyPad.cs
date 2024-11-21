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
    public GameObject happyJosh, disappointedJosh;

     void Start()
    {
       Ans.text = "XXX";
       happyJosh.SetActive(false);
       disappointedJosh.SetActive(false);

    }
    // Start is called before the first frame update
    public void Number(int number)
    {
        if(Ans.text == "XXX"){
            Ans.text = "";
        }
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
            happyJosh.SetActive(true);
            door.OpenDoor();
            StartCoroutine(ClearScreen());
        } 
       else
        {
            Ans.text = "Invalid";
            disappointedJosh.SetActive(true);
            StartCoroutine(ClearScreen());
        }
    }//end enter function

    IEnumerator ClearScreen(){
        yield return new WaitForSeconds(2);
        Ans.text="";
        happyJosh.SetActive(false);
        disappointedJosh.SetActive(false);
    }
   
}//end class
