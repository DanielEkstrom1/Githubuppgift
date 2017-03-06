using UnityEngine;
using System.Collections;

public class Uppgift3 : MonoBehaviour

{
    // Values
    public int a;
    public int b;

    // Them Method
    int Add(int a, int b)
    {
        return a + b;
    }
    // Use this for initialization
    void Start()
    {
        // Adds the values then prints the result 
        int t = Add(a, b);
        Debug.Log(t);

    }
}