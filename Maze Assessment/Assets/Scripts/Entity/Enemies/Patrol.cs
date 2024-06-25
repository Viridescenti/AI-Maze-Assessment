using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : Enemy
{
    public Transform[] patrolPoints;
    public float transferDist = 0.5f;

    private int patrolIndex = 0;

    //Returns a line instantly without a body.
    private Vector3 GetPoint(int index)
        => patrolPoints[index].position;

    public void Start()
    {
        state = EnemyState.Follow;
        Target(patrolPoints[patrolIndex].position);
    }

    public void Update()
    {
        if (GetDist(transform.position, GetPoint(patrolIndex)) < transferDist)
        {
            patrolIndex++;
        }


        if (patrolPoints.Length == patrolIndex)
        {
            patrolIndex = 0;
        }

        Target(patrolPoints[patrolIndex].position);
    }
}