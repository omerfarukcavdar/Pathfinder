using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptColor : MonoBehaviour {
    Renderer myRendere;
    Color myColor;
    float r, g, b;
	// Use this for initialization
	void Start () {
        
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);
        myColor = new Color(r, g, b);
        gameObject.GetComponent<Renderer>().material.color = myColor;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
