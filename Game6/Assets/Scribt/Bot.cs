using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Bot : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;

    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = Player.instance.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
        
        
    }
}
