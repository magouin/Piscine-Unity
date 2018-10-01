using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baloon : MonoBehaviour {

	// Use this for initialization
	private float size;
	private	float time;
	private int nb;

	void Start () {
		nb = 0;
	}
	
	// Update is called once per frame
	void Update () {
		size = Time.deltaTime * -0.2f;
		time += Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Space) && nb < 10)
        {
            size += 0.1f;
			print(nb);
			nb++;
        }
        if (transform.localScale.x > 3f || transform.localScale.x <= 0f)
		{
        	Destroy(gameObject);
			print("Balloon life time: " + (int)time + "s");
		}
		if (((int)time % 3 == 0))
		{
			nb = 0;
		}
		transform.localScale += new Vector3(size, size, 0);
	}
}
