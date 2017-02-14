using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingController : MonoBehaviour {
    public float baseSpeed;
    public float increaseRate;
    private float timeSoFar;
    public float steeringForce;
    public float speed;
    public float acceleration;
	// Use this for initialization
	void Start () {
        speed = baseSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        timeSoFar += Time.deltaTime;


        Vector3 localVel = new Vector3();
        speed += increaseRate * Time.deltaTime + Input.GetAxis("Vertical") * acceleration * Time.deltaTime;
        localVel.z = speed;
        GetComponent<Rigidbody>().velocity = transform.TransformDirection(localVel);

        transform.Rotate(new Vector3(0, steeringForce * Input.GetAxis("Horizontal") * Time.deltaTime, 0));

    }
}
