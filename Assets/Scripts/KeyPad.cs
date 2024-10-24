using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class KeyPad : MonoBehaviour
{
    [SerializeField] public TMP_Text Ans;
    public string Answer = "645";
    public GameObject DoorObject;
    public float toggleDistance = 50f;
    public bool doorObjectV;


     void Start()
    {
       DoorObject.SetActive(true); 
    }
    // Start is called before the first frame update
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    // Update is called once per frame
    public void Enter()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Correct";
            if (!doorObjectV)
            {
                Vector3 playerPosition = transform.position;
                Vector3 objectPosition = DoorObject.transform.position;
                float distance = Vector3.Distance(playerPosition, objectPosition);

                if (distance <= toggleDistance)
                {
                    doorObjectV = false;
                    DoorObject.SetActive(false);
                }


            }
        } 
       else
        {
            Ans.text = "Invalid";
        }
    }
}
