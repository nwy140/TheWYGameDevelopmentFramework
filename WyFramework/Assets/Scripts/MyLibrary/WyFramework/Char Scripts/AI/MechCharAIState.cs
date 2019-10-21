using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; /// to use navmesh

public enum AISTATE{
	IDLE,
	WALK,
	RUN,
	PAUSE,
	GOBACK,
	ATTACK,
	DEATH,

}

public class MechCharAIState : MonoBehaviour {
	private float attack_Distance = 1.5f;
	private float alert_Attack_Distance = 8f; //Alert AI to attack Target when within distance
	private float followDistance = 15f;
	private float enemyToTargetDistance; // Distance between enemy and Target

	[HideInInspector]
	public AISTATE enemy_CurrentState = AISTATE.IDLE;

	public AISTATE enemy_LastState;

	private Transform target;
	private Vector3 initialPosition;

	private float move_Speed = 2f;
	private float walk_Speed = 1f;

	private CharacterController CharController;
	private Vector3 whereTo_Move = Vector3.zero;

	private float currentAttackTime;
	private float waitAttackTime = 1f;

	private Animator anim;
	private bool finished_Animation = true;
	private bool finished_Movement = true;

	private NavMeshAgent navAgent;
	private Vector3 whereTo_Navigate;

	//Health
	private MechCharStatHP mMechCharStatHP;

	// Use this for initialization
	void Awake () {
		navAgent = GetComponent<NavMeshAgent>();
		CharController = GetComponent<CharacterController>();
		anim = GetComponent<Animator>();
		mMechCharStatHP = GetComponent<MechCharStatHP>();

		initialPosition = transform.position;
		whereTo_Navigate = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		// IF HEALTH <= 0 Set State to death
		if(mMechCharStatHP.currentHP<=0){
			enemy_CurrentState = AISTATE.DEATH;
		}
		else{

		}

	

	}

	AISTATE SetEnemyState (AISTATE curState, AISTATE lastState, AISTATE enemyToPlayerDis){
				
		if (true){
			lastState = curState;
			curState = AISTATE.GOBACK;

		} else if(true){

			lastState = curState;
			curState = AISTATE.ATTACK;
		
		} 

		return curState;

	}

	void GetStateControl (AISTATE curState) {
		if (curState == AISTATE.RUN || 	curState == AISTATE.PAUSE){
			if (curState!=AISTATE.ATTACK){

					
			}
		} else if (curState== AISTATE.ATTACK){

		} else if (curState == AISTATE.GOBACK){
			
		} else if (curState==AISTATE.WALK){
		}
	}






	
}
