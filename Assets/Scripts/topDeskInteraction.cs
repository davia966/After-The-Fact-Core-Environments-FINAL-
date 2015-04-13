using UnityEngine;
using System.Collections;

public class topDeskInteraction : MonoBehaviour {
	
	public bool isOpen = false;

	//This code opens and closes the top drawer of the bedroom desk.
	//NOTE: Could not get the animations to work like the nightstand.

	void Start(){

		//transform.position.Set (0, 0, 0);

	}
	
	void OnMouseDown() {

		if (isOpen == false){
			//transform.position = new Vector3 (transform.position.x, transform.position.y, 0.0317f);
			GetComponent<Animation>().Play("Top Desk Open");
			isOpen = true;

		}else{
			//transform.position = new Vector3 (transform.position.x, transform.position.y, -0.0317f);
			GetComponent<Animation>().Play("Top Desk Close");
			isOpen = false;

		}
	}
}
