using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;
	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        // Get the mouse delta. This is not in the range -1...1
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(v, h, 0);
    }
}
