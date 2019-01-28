using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raining : MonoBehaviour
{
    public GameObject rain;
    public float rainingSpeed = 100f;
    public float deathTime = 7;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

            GameObject instRain = Instantiate(rain, new Vector3(Random.Range(-50.0f, 50.0f), 30, Random.Range(-50.0f, 50.0f)), Quaternion.identity) as GameObject;
            Rigidbody  instRainBody = instRain.GetComponent<Rigidbody>();
            GameObject.Destroy(instRain, deathTime);

    }
}
