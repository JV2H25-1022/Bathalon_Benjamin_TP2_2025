using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentAutonome : MonoBehaviour
{
    public Transform cible;
    public NavMeshAgent agent;
    public RetireTrash Score;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(cible.position);
    }
}
