using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class MechCharAINavMeshPatrol : MonoBehaviour
{
	public List<Transform> patrolPoints;
	public int patrolIndex = 0;
	public float reachDestinationRadius = 50f; 
	
	private NavMeshAgent mNavMeshAgent;
    void Start()
	{
	    mNavMeshAgent = GetComponent<NavMeshAgent>();
        
	    setPatrolDestinationByIndex(patrolIndex);
    }

  void Update()
	{
		if(CheckHasReachDestination(reachDestinationRadius)){
			patrolIndex++;
		}
		setPatrolDestinationByIndex(Mathf.Clamp(patrolIndex,0,patrolPoints.Count-1));
		if(patrolIndex > patrolPoints.Count-1 ) { // if it's a last point
			patrolIndex = 0;
		}
	}
	

	public void setPatrolDestinationByIndex(int indexVal){
		mNavMeshAgent.destination = patrolPoints[indexVal].position;
	}
    
	// TODO fix destinationRadius
	public bool CheckHasReachDestination(float destinationRadius){
		// Check if we've reached the destination
		// Check if we've reached the destination
		if (!mNavMeshAgent.pathPending && mNavMeshAgent.isActiveAndEnabled)
		{
			if (mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
			{
				if (!mNavMeshAgent.hasPath || mNavMeshAgent.velocity.sqrMagnitude < destinationRadius)
				{
					return true;
				}
			}
		}
		return false;
	}
	

}

