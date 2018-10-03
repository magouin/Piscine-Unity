using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour {

	public GameObject porte;
	public int color;

	private	playerScript_ex04 tmp;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	private void OnTriggerStay2D(Collider2D other) {
		if (Input.GetKeyDown("e"))
		{
			tmp = other.gameObject.GetComponent<playerScript_ex04>();
			if (color == 3 || tmp.go_id == color)
			{
				if (porte.activeSelf == true)
					porte.SetActive(false);
				else
					porte.SetActive(true);
			}
		}
	}
}
