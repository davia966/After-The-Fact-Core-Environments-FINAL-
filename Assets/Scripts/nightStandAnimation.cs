using UnityEngine;
using System.Collections;

public class nightStandAnimation : MonoBehaviour {

	public GameObject drawer;
	public bool isOpen = false;

	void OnMouseDown(){

		if(!this.isOpen){

			drawer.GetComponent<Animation>().Play("open");

			this.isOpen = true;

		}else{
			drawer.GetComponent<Animation>().Play("close");

			this.isOpen = false;

		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
