using UnityEngine;
using System.Collections;

public class doorAnimation : MonoBehaviour {
	
	public GameObject door;
	public bool isOpen = false;
	
	void OnMouseDown(){
		
		if(!this.isOpen){
			
			door.GetComponent<Animation>().Play("door open");
			
			this.isOpen = true;
			
		}else{
			door.GetComponent<Animation>().Play("door close");
			
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

