using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject obstacle;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle", 1f, 3f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateObstacle()
	{

		Instantiate (obstacle);
	}
}
