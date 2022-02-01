using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public string behaviorState = "wander";
    
    // Start is called before the first frame update
    void Start()
    {
        
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
        //insert code here
    }
}
