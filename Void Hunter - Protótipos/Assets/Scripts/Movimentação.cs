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
        //Movimentação
        rig.velocity.Normalize();
        movimento.x = Input.GetAxis("Horizontal");
        movimento.y = Input.GetAxis("Vertical");
        rig.velocity = new Vector2(movimento.x * speed, movimento.y * speed);

        //Animação
        if (movimento.x != 0)
        {
            anima.SetFloat("Speed", Mathf.Abs(movimento.x));
            //O sprite olha pro lado que o jogador se mover
            transform.localScale = new Vector3(Mathf.Sign(movimento.x), 1f, 1f);
        }
        else if(movimento.y != 0)
        {
            anima.SetFloat("Speed", Mathf.Abs(movimento.y));
        }
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
