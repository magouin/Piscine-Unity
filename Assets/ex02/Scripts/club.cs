using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class club : MonoBehaviour {

	public float y;
	private float power;
	public ball b;
	// Use this for initialization
	void Start () {
		y = -3.73f;
		power = 0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("space"))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 0.2f);
        	power += Time.deltaTime;
        }
        else
        {
        	b.power = power * 10f;
        	transform.position = new Vector3(-0.2f, y, 0);
			power = 0f;
        }
	}
}
