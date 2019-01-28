using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float shootingSpeed = 100f;
    public float deathTime = 3 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletBody = instBullet.GetComponent<Rigidbody>();
            instBulletBody.AddForce(transform.forward * shootingSpeed);
            GameObject.Destroy(instBullet, deathTime);
         
        }
    }
}
