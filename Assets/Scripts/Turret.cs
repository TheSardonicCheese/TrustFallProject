using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;


    void Update()
    {
        //set timer
        //when countdown ends run shoot
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
