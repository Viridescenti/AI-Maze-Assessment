using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public float DoorOpenTime = 5f;
    public Animator anim;

    private bool IsOpen = false;

    public void ActivePlate()
    {
        anim.SetBool("IsOpen", true);

        StartCoroutine(OpenTime());
    }

    public IEnumerator OpenTime()
    {
        //yield (We're waiting for x to happen)
        //return (We're returning a result upon yield)
        //new (Returns a new variable from our emueration)
        //WaitForSeconds (Unity Async functionality for waiting for x amount of time to pass)
        //DoorOpenTime (The amount of time passed)
        yield return new WaitForSeconds(DoorOpenTime);

        anim.SetBool("IsOpen", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Toggle(other.tag, true);
    }

    private void OnTriggerExit(Collider other)
    {
        Toggle(other.tag, false);
    }

    private void Toggle(string tag, bool openning)
    {
        if (tag != "Player")
        {
            return;
        }

        IsOpen = openning;
        anim.SetBool("IsOpen", IsOpen);
    }
}