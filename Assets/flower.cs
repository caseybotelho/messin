using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower : MonoBehaviour {

	public GameObject alium;

	public bool attached = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (attached) {
			float direction = Mathf.Sign (alium.transform.rotation.y);
			float xPos = alium.transform.position.x - (1.0f * direction);

			transform.position = new Vector3(xPos, alium.transform.position.y , 0);
		}
	}

	public void newPos() {
		attached = true;
	}
}
