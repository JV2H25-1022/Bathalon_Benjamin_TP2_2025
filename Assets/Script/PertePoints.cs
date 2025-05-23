using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PertePoints : MonoBehaviour

{
    // Start is called before the first frame update
    public RetireTrash Scoring;
    public AgentAutonome Bot;
    public AgentAutonome Target;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Scoring.Score -= 2;
       
            Invoke("On", 0f);
            Invoke("Off", 2f);

            if (Scoring.Score < 0)
            {
                Scoring.Score = 0;
            }

        }
        Debug.Log("Bonk");
    }

    void On()
    {
        Bot.agent.isStopped = true;
        Bot.agent.SetDestination(Bot.agent.transform.position);
        
    }

    void Off()
    {
        Bot.agent.SetDestination(Target.cible.position);
        Bot.agent.isStopped = false;
    }

}
