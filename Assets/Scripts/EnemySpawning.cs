using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject enemyPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        //int locationIndex = Random.Range(0, spawnLocations.Length);
        //Instantiate(enemyPrefab, spawnLocations[locationIndex].transform.position, enemyPrefab.transform.rotation);
        Debug.Log("this feature is working right");
    }
}
