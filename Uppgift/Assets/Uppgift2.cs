using UnityEngine;
using System.Collections;

public class Uppgift2 : MonoBehaviour {
    public int valA = 10;
    public int valB = 10;

    // Use this for initialization
    void Start()
    {
        if (valA > valB)
        {
            Debug.Log("valA is bigger");
        } 

        else if (valB > valA)
        {
            Debug.Log("valB is bigger");
        }

        else
        {
            Debug.Log("Even");
        }
            
        }
    }

