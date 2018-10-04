using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour {

	// Use this for initialization
	public GameObject vraiment;
	public GameObject menu;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape) && menu.gameObject.activeSelf == false  && vraiment.gameObject.activeSelf == false)
		{
			gameManager.gm.pause(true);
			menu.gameObject.SetActive(true);
		}
	}
}
