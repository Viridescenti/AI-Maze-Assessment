using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public int Value = 1;
    public UnityEvent<int> coinCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }

        coinCollected.Invoke(Value);
        Destroy(gameObject);
    }
}