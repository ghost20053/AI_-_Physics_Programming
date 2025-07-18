using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Vector3 RandomPoint;
    public Vector3 RandomPointOnPlane;
    public bool isPatrolling;
    public float speed;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        speed = 10;
    }
    void Update()
    {
        if (isPatrolling == false)
        { //it finished the current patrol and need other point
            RandomPoint = Random.insideUnitSphere * 6; //find point in sphere
            RandomPointOnPlane = new Vector3(RandomPoint.x, RandomPoint.y, RandomPoint.z); //find the random point on terrain
            agent.SetDestination(RandomPointOnPlane); //set the patrolling target
            isPatrolling = true; //it received a target
    }
        if (agent.remainingDistance > 0)
        {
            isPatrolling = true; //still patrolling
        }
        else
        {
            isPatrolling = false; //it finished the current patrolle and need other point
        }
    }
}
