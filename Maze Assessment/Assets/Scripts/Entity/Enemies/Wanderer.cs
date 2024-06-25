using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wanderer : Enemy
{
    public float slowingDist = 2f;

    public void Start()
    {
        state = EnemyState.Follow;
    }

    public void Update()
    {
        if (GetDist(player.position, transform.position) < slowingDist)
        {
            agent.isStopped = true;
            return;
        }

        Target(player.position);
        agent.isStopped = false;
    }
}