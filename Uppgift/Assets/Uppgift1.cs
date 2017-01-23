using UnityEngine;
using System.Collections;

public class Uppgift1 : MonoBehaviour {
    public int valA = 5;
    public int valB = 10;
    private int valC = 0;
    private int valD = 0;

	// Use this for initialization
	void Start () {
        valC = valA;
        valD = valB;
        valB = valC;
        valA = valD;       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
