using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;

    public Transform firePoint;

    public Transform enemy;
    public GameObject[] Enemies;

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
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject EnemyNearDistance = GetEnemyNearby();
        if (timeBetween <= 0)
        {
            Vector3 targetDirection = transform.position - EnemyNearDistance.transform.position ;
            Instantiate(bullet, firePoint.position, Quaternion.LookRotation(new Vector3(0, 0, 1), -targetDirection));
            timeBetween = startTimeBetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }

    private GameObject GetEnemyNearby() {

        var NearDistance = float.MaxValue;
        GameObject EnemyNearDistance = null;

        foreach(var Enemy in Enemies)
        {
            if(Vector3.Distance(Enemy.transform.position, GameObject.Find("Char").transform.position) < NearDistance)
            {
                NearDistance = Vector3.Distance(Enemy.transform.position, GameObject.Find("Char").transform.position);
                EnemyNearDistance = Enemy;
            }
        }
        //Debug.DrawLine(GameObject.Find("Char").transform.position, EnemyNearDistance.transform.position, Color.red);
        return EnemyNearDistance;
    }

}
