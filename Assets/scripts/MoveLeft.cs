using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {

	Vector2 LeftSide = new Vector2(0, 0);
	Vector2 RightSide = new Vector2(0, 0);

	Vector3 pos = new Vector3(5, 0, 0);
	public GameObject other;


	// Use this for initialization
	void Start () {
		LeftSide.x = Screen.width / 3;
		//LeftSide.y = Screen.height / 2 - 100;
		RightSide.x = LeftSide.x * 2;
        
	

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.mousePosition.x > 0 && Input.mousePosition.x < LeftSide.x && Input.GetMouseButton(0)) {
		

			//other.transform.position = pos;
            other.rigidbody.AddForce(pos);
		}

		if (Input.mousePosition.x > RightSide.x && Input.mousePosition.x < Screen.width && Input.GetMouseButton(0)) {
			//other.transform.position = -pos;
            other.rigidbody.AddForce(-pos);
				}
	}
}
