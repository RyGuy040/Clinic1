using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private string behaviorState = "wander";
    public GameObject target;
    public float moveSpeed = 5.0f;
    public LineOfSight playerIsVisible;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    if (playerIsVisible == null)
    {
      playerIsVisible = GetComponent<LineOfSight>();
    }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerIsVisible == true)
        {
            behaviorState = "attack";
        }

        if(playerIsVisible == false)
        {
            behaviorState = "wander";
        }
        
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

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fireball"))
        {
            Destroy(gameObject);
        }
    }

}
