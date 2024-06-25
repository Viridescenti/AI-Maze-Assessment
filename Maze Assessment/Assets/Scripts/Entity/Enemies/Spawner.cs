using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    private bool canSpawn = true;

    public void SpawnObject()
    {
        if (canSpawn)
        {
            Instantiate(ObjectToSpawn, new Vector3(transform.position.x, 1.5f, transform.position.z), Quaternion.identity);
            canSpawn = false;
        }
    }
}
