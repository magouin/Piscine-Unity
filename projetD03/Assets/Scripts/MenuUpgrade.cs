using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUpgrade : MonoBehaviour {

	private void OnMouseOver() {
		if (Input.GetMouseButton(1))
			Debug.Log("Coucou");
	}
	[HideInInspector] public towerScript tower;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
