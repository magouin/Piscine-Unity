using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Drag_Drop : MonoBehaviour {
	public GameObject turret;
    private bool dragging = false;
    private float distance;
	private GameObject img;
	private GameObject[] empty;

	void Start(){
		empty = GameObject.FindGameObjectsWithTag("empty"); 
	}
     void OnMouseDown()
    {
		img = Instantiate(gameObject, transform.position, transform.rotation, transform.parent);
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }
 
    void OnMouseUp()
    {
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		if(hit)
		{
			if (hit.collider.gameObject.tag == "empty")
			{
				if (gameManager.gm.playerEnergy >= turret.GetComponent<towerScript>().energy)
				{
					gameManager.gm.playerEnergy -= turret.GetComponent<towerScript>().energy;
					img.transform.position = hit.collider.gameObject.transform.position;
					Instantiate(turret, img.transform.position, img.transform.rotation);
				}
				else
					print("Not enought energy: " + gameManager.gm.playerEnergy);
			}
		}
		Destroy(img.gameObject);
        dragging = false;
    }
 
    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            img.transform.position = rayPoint;
        }
    }
}
