using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public string tag;
	private	playerScript_ex01 tmp;
	private GameObject[] red;
	private GameObject[] yellow;
	private GameObject[] blue;

	// Use this for initialization
	void Start () {
		red = GameObject.FindGameObjectsWithTag("Rouge");
		yellow = GameObject.FindGameObjectsWithTag("Jaune");
		blue = GameObject.FindGameObjectsWithTag("Bleu");
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnTriggerStay2D(Collider2D other) {
		if (Input.GetKeyDown("e"))
		{
			tmp = other.gameObject.GetComponent<playerScript_ex01>();
			if (tmp.go_id == 1)
			{
				foreach (GameObject rouge in red)
				{
					rouge.layer = 12;
					rouge.GetComponent<Renderer>().material.SetColor("_Color", new Color(0xD6 / 255f, 0x45 / 255f, 0x42 / 255f, 0xFF / 255f));
				}
			}
			if (tmp.go_id == 2)
			{

				foreach (GameObject jaune in yellow)
				{
					jaune.layer = 14;
					jaune.GetComponent<Renderer>().material.SetColor("_Color", new Color(0xA9 / 255f, 0x96 / 255f, 0x47 / 255f, 0xFF / 255f));
				}
			}
			if (tmp.go_id == 3)
			{
				foreach (GameObject bleu in blue)
				{
					bleu.layer = 13;
					bleu.GetComponent<Renderer>().material.SetColor("_Color", new Color(0x25 / 255f, 0x3D / 255f, 0x5F / 255f, 0xff / 255f));
				}
			}
		}
	}
}
