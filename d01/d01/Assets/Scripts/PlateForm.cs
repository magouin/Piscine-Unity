using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateForm : MonoBehaviour {

	// Use this for initialization
	private float x_o;
	private int sens;
	private Rigidbody2D rb;

	void Start () {
		sens = 1;
		rb = GetComponent<Rigidbody2D>();
		x_o = rb.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		rb.MovePosition(rb.position + ((new Vector2(sens, 0)) * Time.deltaTime));
		if (x_o - rb.position.x > 2)
			sens = 1;
		if (rb.position.x - x_o > 2)
			sens = -1;
	}
}
