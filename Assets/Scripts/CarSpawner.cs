using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour {
    public GameObject car;
    public List<GameObject> cars;
    public int numberofCars;
    public float laneOffset;
    public float spaceBetweenCars;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < numberofCars; i++)
        {
            
            if(Random.Range(0f, 1f)>.5f)
            {
                cars.Add((GameObject)Instantiate(car, transform.position + new Vector3(laneOffset, 0, i * spaceBetweenCars), transform.rotation));
            }
            else
            {
                cars.Add((GameObject)Instantiate(car, transform.position + new Vector3(-laneOffset, 0, i * spaceBetweenCars), transform.rotation));
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
