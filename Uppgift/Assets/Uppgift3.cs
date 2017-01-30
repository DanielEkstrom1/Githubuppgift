using UnityEngine;
using System.Collections;

public class Uppgift3 : MonoBehaviour {
    public int a;
    public int b;

    int Add(int a, int b) {
        return a + b;
    }
    // Use this for initialization
    void Start() {

        int t = Add(a, b);
        Debug.Log(t);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
