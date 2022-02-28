using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SRC_Procedural_Terrain : MonoBehaviour
{
    public NavMeshSurface2d surface;
    public GameObject Terrain;
    public Transform parent;
    public float x, y;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*GameObject Player = GameObject.FindGameObjectWithTag("Player");
        GameObject[] Terrains = GameObject.FindGameObjectsWithTag("Terrains");
        foreach(GameObject Terra in Terrains){

        }*/
        SpawnTerrain(Terrain, x, y);
    }

    void SpawnTerrain(GameObject obj, float x, float y){
        if(count < 1)
        {
            Instantiate(obj, new Vector2(x, y), obj.transform.rotation, parent);
            surface.BuildNavMesh();
            count++;
        }
        
    }
}
