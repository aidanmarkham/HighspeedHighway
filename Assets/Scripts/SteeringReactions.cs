using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringReactions : MonoBehaviour {
    public GameObject driverCam;
    public GameObject steeringWheel;

    public float degreesToTurnWheel;
    public float degreesToTurnCamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        steeringWheel.transform.localEulerAngles = new Vector3(0, degreesToTurnWheel * Input.GetAxis("Horizontal"), 0);
        driverCam.transform.localEulerAngles = new Vector3(0, degreesToTurnCamera * Input.GetAxis("Horizontal"), 0);

    }
}
