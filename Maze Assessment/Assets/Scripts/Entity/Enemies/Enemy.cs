using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyState state = EnemyState.Idle;
    public Transform target;
    public Transform player;
    public UnityEngine.AI.NavMeshAgent agent;

    public void Target(Vector3 target)
    {
        agent.SetDestination(target);
    }

    public float GetDist(Vector3 agent, Vector3 target)
    {
        var dist = Vector3.Distance(agent, target);
        return dist;
    }

    public void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
}

public enum EnemyState
{
    Follow,
    Idle,
    Guard
}