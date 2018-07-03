using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveControllerInputTest : MonoBehaviour {
	public SteamVR_Controller.Device controller {
		get {
			return SteamVR_Controller.Input ((int)GetComponent<SteamVR_TrackedObject> ().index);
		}
	}

	void Update(){
		if (controller.GetHairTriggerDown())
		{
			Debug.Log(gameObject.name + " Trigger Press");
		}
	}
}
