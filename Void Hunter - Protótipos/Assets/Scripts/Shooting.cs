using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;

    public Transform firePoint;

    public Transform enemy;

    float timeBetween;
    public float startTimeBetween;
    // Start is called before the first frame update
    void Start()
    {
        timeBetween = startTimeBetween;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeBetween <= 0)
        {
            Vector3 targetDirection = transform.position - enemy.position;
            Instantiate(bullet, firePoint.position, Quaternion.LookRotation(new Vector3(0, 0, 1), -targetDirection));
            timeBetween = startTimeBetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }

}
