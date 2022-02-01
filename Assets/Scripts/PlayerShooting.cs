using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject player;
    public GameObject fireSpawner;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Debug.Log("this feature is working right");
            Instantiate(projectilePrefab, fireSpawner.transform.position, player.transform.rotation);
        }
    }
}
