using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private static GameManager instance = null;

	public static GameManager Instance
	{
		get
		{
			if(instance == null)
			{
				instance = FindObjectOfType(typeof(GameManager)) as GameManager;

				if(instance == null)
					Debug.LogError("Can not find Find GameManager");
			}

			return instance;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
