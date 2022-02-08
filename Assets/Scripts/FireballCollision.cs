using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Enemy"))
        {
            GameObject playerDamage = Destroy(gameObject);
            playerDamage.GetComponent<EnemySpawning>().numberOfEnemies = -1;
            Destroy(other.gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
