using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {

	float LeftX = 0.0f;
    float RightX = 0.0f;
    float y = 0.0f;

	Vector3 pos = new Vector3(5, 0, 0);
    Vector3 up = new Vector3(0, 5, 0);
	public GameObject other;


	// Use this for initialization
	void Start () {
        LeftX = Screen.width / 3;
		
        RightX = LeftX * 2;

        y = Screen.height / 2 - 100;
	

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.mousePosition.x > 0 && Input.mousePosition.x < LeftX && Input.GetMouseButton(0))
        {
		

			//other.transform.position = pos;
            other.rigidbody.AddForce(pos);
		}

        if (Input.mousePosition.x > RightX && Input.mousePosition.x < Screen.width && Input.GetMouseButton(0))
        {
			//other.transform.position = -pos;
            other.rigidbody.AddForce(-pos);
				}

        if (Input.mousePosition.y < y && Input.mousePosition.x > 0 && Input.GetMouseButton(0))
        {
            //other.transform.position = -pos;
            other.rigidbody.AddForce(up);
        }
	}
}
