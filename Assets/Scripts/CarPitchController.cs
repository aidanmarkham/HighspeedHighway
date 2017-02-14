using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPitchController : MonoBehaviour
{
    public int gear;
    public float gearScale;
    private float carSpeed;
    private AudioSource audioSource;
    public float targetPitch;
    public float pitchAdjustSpeed;
    public float maxPitch;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        carSpeed = GetComponent<DrivingController>().speed;

        targetPitch = carSpeed / (gear * gearScale);


        if (audioSource.pitch - targetPitch < 0)
        {
            audioSource.pitch += pitchAdjustSpeed * Time.deltaTime;
        }
        else
        {
            audioSource.pitch -= pitchAdjustSpeed * Time.deltaTime;
        }

        if(targetPitch > maxPitch)
        {
            gear++;

        }
    }
}
