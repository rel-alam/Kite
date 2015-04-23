using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
 
	}
	// Update is called once per frame
    void Update()
    {

        Vector3 temp = gameObject.transform.position;
        temp.z += 4 * Time.deltaTime;
        gameObject.transform.position = temp; // = MoveZ;

    }


    void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("death"))
        {
            Destroy(gameObject);
        }
    }
}


