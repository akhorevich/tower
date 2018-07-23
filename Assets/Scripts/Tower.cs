using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Tower : MonoBehaviour {

	public bool isCreate;
	public GameObject spawnObject;

	// Use this for initialization
	void Start () {
		
		if (isCreate)
		{
			Instantiate(spawnObject, new Vector3(transform.position.x, transform.position.y+0.75f, transform.position.z), transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
