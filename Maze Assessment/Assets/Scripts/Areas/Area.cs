using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Area : MonoBehaviour 
{
    public List<NavMeshAgent> affectedAgents = new List<NavMeshAgent>();

    public float areaEffectTime = 4f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<NavMeshAgent>(out var agent))
        {
            if (affectedAgents.Contains(agent))
            {
                return;
            }

            affectedAgents.Add(agent);
            StartCoroutine(Entered(agent));
        }
    }

    public abstract IEnumerator Entered(NavMeshAgent agent);
    public abstract void Effect(NavMeshAgent agent);
    public abstract void Revoke(NavMeshAgent agent);
}