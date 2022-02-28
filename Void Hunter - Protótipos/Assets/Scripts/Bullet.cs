using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rig;
    private int MaxEnemyHit = 3;
    private int hitcount = 0;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();      
        
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D Enemy)
    {
        if(Enemy.gameObject.tag == "Enemy")
        {
            //Debug.Log("Hit on Slime");
            Destroy(Enemy.gameObject);
            hitcount++;
        }
        if(hitcount == MaxEnemyHit){
            Destroy(gameObject);
            hitcount = 0;
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
