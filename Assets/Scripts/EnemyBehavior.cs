using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private string behaviorState = "wander";
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
        GameObject.Find("Enemy").GetComponent<Pathfinder>().BoolSwitchTrue();
    }

    public void RamItDown()
    {
        GameObject.Find("Enemy").GetComponent<Pathfinder>().BoolSwitchFalse();
        transform.LookAt(target.transform.position);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fireball"))
        {
            Destroy(gameObject);
        }
    }

    public void BoolSwitchTrue()
    {
        behaviorState = "attack";
    }

    public void BoolSwitchFalse()
    {
        behaviorState = "wander";
    }
}
