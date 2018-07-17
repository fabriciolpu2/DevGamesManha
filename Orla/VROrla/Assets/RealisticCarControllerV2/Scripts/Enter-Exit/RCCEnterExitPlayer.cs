//----------------------------------------------
//            Realistic Car Controller
//
// Copyright © 2015 BoneCracker Games
// http://www.bonecrackergames.com
//
//----------------------------------------------

using UnityEngine;
using System.Collections;

public class RCCEnterExitPlayer : MonoBehaviour {
	
	public float maxRayDistance= 2.0f;
	private bool showGui = false;
	
	void Update (){
		
		Vector3 direction= transform.TransformDirection(Vector3.forward);
		RaycastHit hit;

		if(Physics.Raycast(transform.position, direction, out hit, maxRayDistance)){

			if(hit.transform.GetComponentInParent<RCCCarControllerV2>()){

				showGui = true;
				
				if(Input.GetKeyDown(KeyCode.E))
					hit.transform.root.SendMessage("Act", GetComponentInParent<CharacterController>().gameObject, SendMessageOptions.DontRequireReceiver);

			}else{

				showGui = false;

			}
			
		}else{

			showGui = false;

		}
		
	}
	
	void OnGUI (){
		
		if(showGui){
			GUI.Label( new Rect(Screen.width - (Screen.width/1.7f),Screen.height - (Screen.height/1.4f),800,100),"Press ''E'' key to Get In");
		}
		
	}
	
}