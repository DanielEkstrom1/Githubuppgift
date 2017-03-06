using UnityEngine;
using System.Collections;

public class Uppgift2 : MonoBehaviour

    // Values of valA and valB

{
    public int valA = 10;
    public int valB = 10;

    // Use this for initialization
    void Start()      

    {
        // Decides what the biggest value is
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

