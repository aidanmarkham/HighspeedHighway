using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingController : MonoBehaviour {
    public float baseSpeed;
    public float increaseRate;
    private float timeSoFar;
    public float steeringForce;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeSoFar += Time.deltaTime;


        Vector3 localVel = new Vector3();
        localVel.z = baseSpeed + (timeSoFar * increaseRate);
        GetComponent<Rigidbody>().velocity = transform.TransformDirection(localVel);

        transform.Rotate(new Vector3(0, steeringForce * Input.GetAxis("Horizontal"), 0));

    }
}
