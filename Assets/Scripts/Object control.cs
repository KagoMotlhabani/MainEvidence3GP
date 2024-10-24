using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectcontrol : MonoBehaviour
{
    public GameObject objectToToggleR; //red objects
    public GameObject objectToToggleB; //blue objects
    public GameObject objectToToggleG; //green objects
    public float toggleDistance = 20f; //player must be within this distance to toggle objects
    public bool objectVisibleB;
    public bool objectVisibleG;
    public bool objectVisibleR;

    // Start is called before the first frame update
    void Start()
    {
        objectToToggleB.SetActive(false);
        objectToToggleG.SetActive(false);
        objectToToggleR.SetActive(false);
    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {

            ObjectVisibilityB();
            if (objectVisibleR)
            {
                objectVisibleR = false;
                objectToToggleR.SetActive(false);
            }
            if (objectVisibleG)
            {
                objectVisibleG = false;
                objectToToggleG.SetActive(false);
            }



        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ObjectVisibilityR();
            if (objectVisibleB)
            {
                objectVisibleB = false;
                objectToToggleB.SetActive(false);
            }
            if (objectVisibleG)
            {
                objectVisibleG = false;
                objectToToggleG.SetActive(false);
            }



        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ObjectVisibilityG();
            if (objectVisibleB)
            {
                objectVisibleB = false;
                objectToToggleB.SetActive(false);
            }
            if (objectVisibleR)
            {
                objectVisibleR = false;
                objectToToggleR.SetActive(false);
            }


        }
    }
    public void ObjectVisibilityB()
    {
        if (!objectVisibleB)
        {
            Vector3 playerPosition = transform.position;
            Vector3 objectPosition = objectToToggleB.transform.position;
            float distance = Vector3.Distance(playerPosition, objectPosition);

            if(distance <= toggleDistance)
            {
                objectVisibleB = true;
                objectToToggleB.SetActive(true);
            }


        }

    }

    public void ObjectVisibilityR()
    {
        if (!objectVisibleR)
        {
            Vector3 playerPosition = transform.position;
            Vector3 objectPosition = objectToToggleR.transform.position;
            float distance = Vector3.Distance(playerPosition, objectPosition);

            if (distance <= toggleDistance)
            {
                objectVisibleR = true;
                objectToToggleR.SetActive(true);
            }




        }
    }

    public void ObjectVisibilityG()
    {
        if (!objectVisibleG)
        {
            Vector3 playerPosition = transform.position;
            Vector3 objectPosition = objectToToggleG.transform.position;
            float distance = Vector3.Distance(playerPosition, objectPosition);

            if (distance <= toggleDistance)
            {
                objectVisibleG = true;
                objectToToggleG.SetActive(true);
            }
        }
    }
}
