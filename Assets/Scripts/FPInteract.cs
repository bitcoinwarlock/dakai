using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPInteract : MonoBehaviour {

	//public GameObject Target;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	
		if (Physics.Raycast (ray, out hit)){
			GameObject target = hit.transform.gameObject;

			if (Input.GetButtonDown ("Submit")) {
				//Debug.Log (targe);
				Interact (target);
			}
		}
	}


	void Interact(GameObject target) {
		//TODO: Trigger Dialogue
		target.SendMessage("Speak");
	}
}
