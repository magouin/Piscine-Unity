using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex00 : MonoBehaviour {

	public int go_id;
	public float masse;
	public float size_x;
	public float size_y;
	public Rigidbody2D rb;
	public int finish;

	private int input;
	private int can_jump;

	void Start () {
		input = 1;
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.constraints |= RigidbodyConstraints2D.FreezePositionX;
		if (Input.GetKeyDown("1") || Input.GetKeyDown("2") || Input.GetKeyDown("3"))
		{
			rb.constraints |= RigidbodyConstraints2D.FreezePositionX;
			if (Input.GetKeyDown("1"))
				input = 1;
			if (Input.GetKeyDown("2"))
				input = 2;
			if (Input.GetKeyDown("3"))
				input = 3;
		}
		if (go_id == input)
		{
			rb.constraints &= ~RigidbodyConstraints2D.FreezePositionX;
			if (Input.GetKey("space") && can_jump == 1)
			{
				rb.AddForce(new Vector2(0, 1) * 100 * (4 - masse));
				can_jump = 0;
			}
			if (Input.GetKey(KeyCode.LeftArrow))
				rb.AddForce(new Vector2(-1, 0) * 10);
			if (Input.GetKey(KeyCode.RightArrow))
				rb.AddForce(new Vector2(1, 0) * 10);
		}
	}

	private void OnCollisionStay2D(Collision2D coll)
    {
		foreach (ContactPoint2D missileHit in coll.contacts)
		{
			if (missileHit.normal == new Vector2(0, 1))
			{
				can_jump = 1;
				return ;
			}
		}
		can_jump = 0;
	}
}
