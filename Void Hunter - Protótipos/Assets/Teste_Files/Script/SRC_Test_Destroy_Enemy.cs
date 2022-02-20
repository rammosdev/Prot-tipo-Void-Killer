using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRC_Test_Destroy_Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("f"))
        {
            GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach(GameObject Enemy in Enemies)
            Destroy(Enemy);
        }
    }
}
