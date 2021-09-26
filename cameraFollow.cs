using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {


	public Transform myTarget;





	// Use this for initialization
	void Start () {
		
	}
	

	void Update () {


		if(myTarget != null){
			
			Vector3 targPos = myTarget.position;

			targPos.z = transform.position.z;

			transform.position = targPos;
	}
}
}
