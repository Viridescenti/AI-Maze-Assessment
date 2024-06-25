using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;

    private TextMeshProUGUI coinText;
    private int coins = 0;

    private void Start()
    {
        cam = FindAnyObjectByType<Camera>();
        agent = GetComponent<NavMeshAgent>();
        coinText = GameObject.FindWithTag("Coins").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
         if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //Move our agent
                agent.SetDestination(hit.point);
            }
        }
    }

    public void Collect(int value)
    {
        coins += value;
        coinText.text = coins.ToString();
    }
}
