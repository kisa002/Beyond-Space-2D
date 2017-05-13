using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {

	GameManager gameManager;
	Rigidbody2D rgd2d;


	private float h;
	private float v;
	
	private float hspeed = 1f;
	private float vspeed = 50f;

	Transform trans;

	// Use this for initialization
	void Start () {
		gameManager = GameManager.Instance;
		rgd2d = gameObject.GetComponent<Rigidbody2D>();

		trans = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Keyboard();
	}

	private void Keyboard()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			rgd2d.AddForce(Vector2.up * vspeed);
		}

		h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        trans.Translate(moveDir.normalized * Time.deltaTime * hspeed  , Space.Self);
      
		trans.Rotate(new Vector3(0, 0, -h));
	}
}
