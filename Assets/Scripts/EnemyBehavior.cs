using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public string behaviorState = "attack";
    public GameObject target;
    public float moveSpeed = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(behaviorState == "wander")
        {
            WanderState();
        }

        if(behaviorState  == "attack")
        {
            RamItDown();
        }
    }

    public void WanderState()
    {
        //insert code here
    }

    public void RamItDown()
    {
        transform.LookAt(target.transform.position);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
