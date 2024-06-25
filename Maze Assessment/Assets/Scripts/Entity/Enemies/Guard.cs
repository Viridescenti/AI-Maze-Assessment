using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guard : Enemy
{
    public float TowerDist = 1f;
    public float GuardDistance = 3.5f;

    public void Update()
    {
        if (GetDist(target.position, player.position) < GuardDistance)
        {
            state = EnemyState.Follow;
            Target(player.position);
            agent.isStopped = false;
            return;
        }

        if (GetDist(transform.position, target.position) < TowerDist)
        {
            state = EnemyState.Idle;
            agent.isStopped = true;
        }

        if (state != EnemyState.Idle)
        {
            state = EnemyState.Guard;
            Target(target.position);
        }
    }
}