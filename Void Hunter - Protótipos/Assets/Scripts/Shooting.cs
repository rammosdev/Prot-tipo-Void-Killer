using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;

    public Transform firePoint;

    public float range;

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
            Vector3 Direction = firePoint.position - enemy.position;
            firePoint.transform.localRotation = Quaternion.LookRotation(Direction);
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            timeBetween = startTimeBetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }

}
