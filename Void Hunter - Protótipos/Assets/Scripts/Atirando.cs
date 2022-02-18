using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirando : MonoBehaviour
{
    public float speed;

    public float direction;

    public Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = transform.right * speed;   
    }
}
