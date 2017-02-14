using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar : MonoBehaviour {
    public float speed;
    public float speedVariance;
    public float actualSpeed;
    public float audioScale;

    // Use this for initialization
    void Start() {
        actualSpeed = speed + Random.Range(-speedVariance, speedVariance);
        GetComponent<AudioSource>().pitch = 1 + Random.Range(-speedVariance * audioScale, speedVariance * audioScale);
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, actualSpeed);
	}
}
