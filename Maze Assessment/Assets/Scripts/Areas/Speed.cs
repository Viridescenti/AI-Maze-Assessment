using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Speed : Area 
{
    public override IEnumerator Entered(NavMeshAgent agent)
    {
        Effect(agent);
        yield return new WaitForSeconds(areaEffectTime);
        Revoke(agent);
    }

    public override void Effect(NavMeshAgent agent)
    {
        agent.speed *= 2;
    }

    public override void Revoke(NavMeshAgent agent)
    {
        affectedAgents.Remove(agent);
        agent.speed /= 2;
    }
}