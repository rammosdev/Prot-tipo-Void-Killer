using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rig;

    private Animator anima;

    Vector2 Moving;



    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        Moving = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Moving.magnitude >= 1) 
        {
            Moving.Normalize();
        }

        rig.velocity = Moving * speed;
        anima.SetFloat("Speed", Moving.magnitude);

        if (Moving.x != 0)
        {
            transform.localScale = new Vector3(MathF.Sign(Moving.x), 1f, 1f);
        }
    }
}
