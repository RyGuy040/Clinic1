using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCollision : MonoBehaviour
{
    public GameObject playerDamage;
    
    // Start is called before the first frame update
    void Start()
    {
        playerDamage = GameObject.Find("SpawnManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Enemy"))
        {
            int tempPlayer;
            Destroy(gameObject);
            tempPlayer = playerDamage.GetComponent<EnemySpawning>().numberOfEnemies -= 1;
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
