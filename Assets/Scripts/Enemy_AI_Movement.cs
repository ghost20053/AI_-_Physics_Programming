using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Vector3 RandomPoint;
    public Vector3 RandomPointOnTerrain;
    public bool isPatrolling;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }
    void Update()
    {
        if (isPatrolling == false)
        { //it finished the current patrolle and need other point
            RandomPoint = Random.insideUnitSphere * 6; //find point in sphere
            RandomPointOnTerrain = new Vector3(RandomPoint.x, Terrain.activeTerrain.SampleHeight(RandomPoint), RandomPoint.z); //find the random point on terrain
            agent.SetDestination(RandomPointOnTerrain); //set the patrolling target
            isPatrolling = true //it received a target
    }
        if (agent.remainingDistance - agent.stoppingDistance)
        {
            isPatrolling = true; //still patrolling
        }
        else
        {
            isPatrolling = false; //it finished the current patrolle and need other point
        }

}
