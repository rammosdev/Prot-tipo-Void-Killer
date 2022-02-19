using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rig;

    public Animator anima;

    Vector2 movimento;

    public Transform firePoint;
    public GameObject bulletPrefab;



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
        Atirando();
    }

    public void Move()
    {
        movimento = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movimento.magnitude >= 1) movimento.Normalize();
        rig.velocity = movimento * speed;

        anima.SetFloat("Speed", movimento.magnitude);

        if (movimento.x != 0) transform.localScale = new Vector3(Mathf.Sign(movimento.x), 1f, 1f);
    }

    public void Atirando()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Debug.Log("oi");
        }
    }
}
