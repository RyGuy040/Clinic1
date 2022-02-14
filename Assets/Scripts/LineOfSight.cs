using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    public float radius;
    [Range(0,360)]
    public float angle;
    public GameObject player;
    public LayerMask targetMask;
    public LayerMask obstructionMask;
    public bool canSeePlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(FOVroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator FOVroutine()
    {
        float delay = 0.2f;
        WaitForSeconds wait = new WaitForSeconds(delay);

        while(true)
        {
            yield return wait;
            FieldOfViewCheck();
        }
    }

    private void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);

        if(rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;

            if(Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);
                if(!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obstructionMask))
                {
                    canSeePlayer = true;
                    GrabBoolean();
                }
                else
                {
                    canSeePlayer = false;
                    GrabBoolean();
                }
            }
            else
            {
                canSeePlayer = false;
                GrabBoolean();
            }
        }
        else if(canSeePlayer)
        {
            canSeePlayer = false;
            GrabBoolean();
        }
    }

    public bool GrabBoolean()
    {
        return canSeePlayer;
    }
}
