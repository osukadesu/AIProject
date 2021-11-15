using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnBullet;
    public float shootForce = 1500f;
    public float shootRate = 0.5f;
    public float shootRateTime = 0.5f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shootRateTime)
            {
                GameObject newBullet;
                newBullet = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(spawnBullet.up * shootForce);
                shootRateTime = Time.time + shootRate;
            }
        }
    }
}