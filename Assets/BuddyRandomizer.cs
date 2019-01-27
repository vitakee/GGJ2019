using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyRandomizer : MonoBehaviour
{
    public GameObject[] Blues;
    public GameObject[] Reds;
    public GameObject[] Greens;
    public string team;
    // Start is called before the first frame update
    void Start()
    {
        
        switch (team)
        {
            case "red":
                GetComponent<MeshFilter>().mesh = null;
                Reds[Random.Range(0, Reds.Length - 1)].transform.parent = transform;
                break;
            case "blue":
                GetComponent<MeshFilter>().mesh = null;
                Blues[Random.Range(0, Blues.Length - 1)].transform.parent = transform;
                break;
            case "green":
                GetComponent<MeshFilter>().mesh =null;
                Greens[Random.Range(0, Greens.Length - 1)].transform.parent = transform;
                break;
        }
    }
}
