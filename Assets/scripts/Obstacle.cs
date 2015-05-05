using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	// Use this for initialization

	public Vector3 velocity = new Vector3(2, 0, 5);
	public float range = 1;
	void Start () {

		rigidbody.velocity = velocity;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
