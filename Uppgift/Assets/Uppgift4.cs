using UnityEngine;
using System.Collections;

public class Uppgift4 : MonoBehaviour {
    public float valA = 5;
    public float valC = 10;
    public float valB;

    // Use this for initialization
    void Start()
    {

        if (valB < valA)

        {
            Debug.Log("B is smaller");
        }

        else if (valB > valC)

        {
            Debug.Log("B is Bigger");
        }

        else if (valB > valA)

        {
            Debug.Log("B is in between");
        }

        else

        {
            Debug.Log("D is in between ");
        }
    }
}

