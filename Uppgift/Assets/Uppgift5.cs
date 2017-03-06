using UnityEngine;
using System.Collections;

public class Uppgift5 : MonoBehaviour
{
    public int valA = 20;
    public int valB = 10;
    public int valC;
    public float valD = 20;
    public float valE = 0;

    int Method(int a, int b)
    {
        return a + b;
    }
    // Use this for initialization
    void Start()
    {
        valC = Method(valA, valB);
        if (valC < valE || valC > valD)
        {
            Debug.Log("större eller mindre än D och E");
        }
        else
        {
            Debug.Log("Mellan D och E");
        }
    }
}
