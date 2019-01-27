using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Camera cam;
    public float step;
    // Update is called once per frame
    void Update()
    {

        if (gameObject.activeInHierarchy)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
                Debug.LogWarning("Setted Active true to all childs");
            }



            if (Input.GetButtonDown("MoveBuddies"))
            {
                Debug.LogWarning("MoveBuddies pressed");

                for (int i = 0; i < transform.childCount; i++)
                {
                    if (transform.GetChild(i).CompareTag("Buddy"))
                    {
                        Debug.LogWarning("Found Buddy");

                        GameObject Buddy = transform.GetChild(i).gameObject;
                        Vector3 move = Buddy.transform.InverseTransformVector(Vector3.forward);
                        move = new Vector3(move.x, 0, move.z);
                        Buddy.transform.Translate(move);


                        Debug.LogWarning("Moved Buddy");
                    }
                }
            }


        }

    }

    public void Blowing()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).CompareTag("Buddy"))
            {
                Debug.LogWarning("Found Buddy");

                GameObject Buddy = transform.GetChild(i).gameObject;
                Vector3 move = Buddy.transform.InverseTransformVector(Vector3.forward);
                move = new Vector3(move.x, 0, move.z);
                Buddy.transform.Translate(move);


                Debug.LogWarning("Moved Buddy");
            }
        }
    }
}
