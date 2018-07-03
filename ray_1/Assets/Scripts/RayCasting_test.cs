using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting_test : MonoBehaviour {

	public float maxRayDistance;
	public float maxhitpointDistance;
	public bool displayplayer;
	public bool displayplayer_1;

	void Start(){
	}

	void FixedUpdate()
	{
		Ray ray = new Ray (transform.position, Vector3.forward);
		RaycastHit hit;

		Debug.DrawRay (transform.position, transform.position + Vector3.forward * maxRayDistance, Color.red);

		if (Physics.Raycast (ray, out hit, maxRayDistance)) {
			Debug.DrawLine (hit.point, hit.point + Vector3.up * maxhitpointDistance, Color.green);

			if (hit.collider.gameObject.CompareTag ("box_example_1")) {
				displayplayer = true;
			} 
			else if (hit.collider.gameObject.CompareTag ("box_example_2")) {
				displayplayer_1 = true;
			}
		}
		else {
			displayplayer = false;
			displayplayer_1 = false;
		}


	}

}
