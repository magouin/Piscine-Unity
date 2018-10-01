using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public float power;
	public club g;
	private float sens;
	// Use this for initialization
	void Start () {
		power = 0f;
		sens = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > 5f)
			sens = -1f;
		if (transform.position.y > -5f)
			sens = 1f;
        transform.Translate(new Vector3(0, sens, 0) * Time.deltaTime * power);
        power /= 1.05f * Time.deltaTime;
        g.y = transform.position.y - 0.2f;
	}
}
