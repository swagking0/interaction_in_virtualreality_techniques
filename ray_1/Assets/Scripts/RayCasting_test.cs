using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting_test : MonoBehaviour {

	public float maxRayDistance;
	public float maxhitpointDistance;
	public bool displayplayer;
	public bool displayplayer_1;
	//public GameObject laserPrefab;
	//private GameObject laser;
	//private Transform laserTransform;



	void Start(){
		//laser = Instantiate (laserPrefab);
		//laserTransform = laser.transform;
	}

	void FixedUpdate()
	{
		//List<string> shoppinglist = new List<string>();
		//shoppinglist.Add ("box_example_1");
		//shoppinglist.Add ("box_example_2");
		Ray ray = new Ray (transform.position, Vector3.left);
		RaycastHit hit;


		Debug.DrawRay (transform.position, transform.position + Vector3.left * maxRayDistance, Color.red);
		//laser.SetActive(true);

		if (Physics.Raycast (ray, out hit, maxRayDistance)) {
			Debug.DrawLine (hit.point, hit.point + Vector3.up * maxhitpointDistance, Color.green);

			if (hit.collider.gameObject.CompareTag ("box_example_1")) {
				displayplayer = true;
			} else if (hit.collider.gameObject.CompareTag ("box_example_2")) {
				displayplayer_1 = true;
			}
		} else {
			displayplayer = false;
			displayplayer_1 = false;
			//laser.SetActive(true);
			//laserTransform.position = Vector3.Lerp (transform.position, hit.point, 0.5f);
			//laserTransform.LookAt (hit.point);
			//laserTransform.localScale = new Vector3 (laserTransform.localScale.x, laserTransform.localScale.y, maxRayDistance);
		}


	}

}
