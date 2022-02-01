using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject enemyPrefab;
    public int numberOfEnemies;
    
    // Start is called before the first frame update
    void Start()
    {
        numberOfEnemies = 0;
        InvokeRepeating("Spawn", 1.0f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        if(numberOfEnemies < 5)
        {
            int locationIndex = Random.Range(0, spawnLocations.Length);
            Instantiate(enemyPrefab, spawnLocations[locationIndex].transform.position, enemyPrefab.transform.rotation);
            numberOfEnemies += 1;
            //Debug.Log("this feature is working right");
        }
    }
}
