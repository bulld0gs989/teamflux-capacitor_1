using UnityEngine;
using System.Collections;
using System;

public class earthRotate : MonoBehaviour {

	private float oldX;
	// Use this for initialization
	void OnMouseDown () {
		oldX = 0;
		Console.WriteLine (oldX);
	}
	
	// Update is called once per frame
	void Update () {
		if (oldX != Input.mousePosition.x) 
		{
			transform.Rotate(0,20*Time.deltaTime*(-Input.mousePosition.x+oldX),0);
		}
		Console.WriteLine (oldX);
		oldX = Input.mousePosition.x;
	}
}
