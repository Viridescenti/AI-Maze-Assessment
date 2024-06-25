using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredRotationCamera: MonoBehaviour
{
    private Camera cam;
    private Transform player;

    private void Start()
    {
        cam = GetComponent<Camera>();
        player = GameObject.FindWithTag("Player").transform;
    }

    Vector3 GetInputDirection()
    {
        return player.position;
    }

    private void Update()
    {
        Vector3 camDir = GetInputDirection();

        transform.LookAt(camDir);
    }
}