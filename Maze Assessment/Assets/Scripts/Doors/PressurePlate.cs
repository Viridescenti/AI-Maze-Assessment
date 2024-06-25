using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    public UnityEvent OnTriggered;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }    

        anim.SetTrigger("IsOpen");
        OnTriggered.Invoke();
    }

     public void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }

        anim.SetTrigger("IsClose");
    }
}
