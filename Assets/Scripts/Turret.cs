using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float timer;
    public int waitingTime = 3;


    void Update()
    {
        //set timer
        timer += Time.deltaTime;
        if(timer > waitingTime)
        {
            Shoot();
            timer = 0;
        }
        //when countdown ends run shoot
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
