using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenDoorSwitch : MonoBehaviour
{
    private bool IsOpen = false;
    public Animator anim;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "DoorSwitch")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                IsOpen = !IsOpen;

                anim.SetBool("IsOpen", IsOpen);
            }
        }
    }
}
