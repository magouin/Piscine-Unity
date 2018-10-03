using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera_ex03 : MonoBehaviour {

	private int input;
	private Vector3 default_position_claire;
	private Vector3 default_position_john;
	private Vector3 default_position_thomas;

	public	playerScript_ex03 claire;
	public	playerScript_ex03 john;
	public	playerScript_ex03 thomas;

	// Use this for initialization
	void Start () {
		input = 1;
		default_position_claire = new Vector3(-4, 0.1f, 0);
		default_position_john = new Vector3(-2, 0.25f, 0);
		default_position_thomas = new Vector3(-1, 0.25f, 0);
		claire.transform.position = default_position_claire;	
		john.transform.position = default_position_john;	
		thomas.transform.position = default_position_thomas;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("1"))
			input = 1;
		if (Input.GetKeyDown("2"))
			input = 2;
		if (Input.GetKeyDown("3"))
			input = 3;
		if (input == 1)
			transform.position = new Vector3(claire.transform.position.x, claire.transform.position.y, transform.position.z);
		if (input == 2)
			transform.position = new Vector3(john.transform.position.x, john.transform.position.y, transform.position.z);
		if (input == 3)
			transform.position = new Vector3(thomas.transform.position.x, thomas.transform.position.y, transform.position.z);
		if (Input.GetKeyDown("r"))
		{
			claire.transform.position = default_position_claire;	
			john.transform.position = default_position_john;	
			thomas.transform.position = default_position_thomas;	
		}
		if (claire.finish == 1 && john.finish == 1 && thomas.finish == 1)
				SceneManager.LoadScene("ex04", LoadSceneMode.Single);
	}
}
