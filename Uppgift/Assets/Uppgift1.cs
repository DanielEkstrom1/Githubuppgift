using UnityEngine;
using System.Collections;

public class Uppgift1 : MonoBehaviour

{
    // The diffrent values
    public int valA = 5;
    public int valB = 10;
    private int valC = 0;
    private int valD = 0;

    // Use this for initialization
    void Start()
    {

        // Switches the diffrent values of valA and valB with help of valC and valD
        valC = valA;
        valD = valB;
        valB = valC;
        valA = valD;
    }
}
