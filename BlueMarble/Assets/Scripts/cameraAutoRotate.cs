using UnityEngine;
using System.Collections;

public class cameraAutoRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Slowly rotate the object around its X axis at 1 degree/second.
		transform.Rotate(Vector3.right * Time.deltaTime);
		
		// ... at the same time as spinning relative to the global 
		// Y axis at the same speed.
		transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
}
