using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRC_Spawn_Wave : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float RadiusSpawn = 10, time = 1.5f;
    public Transform ParentEnemy;
    public GameObject[] enemies;

    private int Max_Enemy_Wave = 10;
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    IEnumerator SpawnEnemy()
    {
        while(GameObject.FindGameObjectsWithTag("Enemy").Length < Max_Enemy_Wave){
            Vector2 spawnPos = GameObject.Find("Char").transform.position;
            spawnPos += Random.insideUnitCircle.normalized * RadiusSpawn;
            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity, ParentEnemy);
        }
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnEnemy());
    }
}
