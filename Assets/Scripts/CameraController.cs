using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	GameObject rocket;

	Transform rocketPos;

	// Use this for initialization
	void Start () {
		rocket = GameObject.Find("Rocket");
		rocketPos = rocket.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Camera();
	}

	void Camera()
	{
		transform.position = new Vector3(rocketPos.position.x, rocketPos.position.y, -10f);
	}
}
