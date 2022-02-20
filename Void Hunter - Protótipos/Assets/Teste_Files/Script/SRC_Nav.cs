using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SRC_Nav : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Point;
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        Point = GameObject.Find("Char");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Point.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("aAa");
            Destroy(gameObject);
        }
    }
}
