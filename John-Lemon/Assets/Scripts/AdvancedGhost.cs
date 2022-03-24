using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class advancedghost : MonoBehaviour
{
public NavMeshAgent agent;

public Transform player;

public LayerMask whatIsGround, whatIsPlayer;

//Patrolling
public Vector3 walkPoint;
bool walkPointSet;
public float walkPointRange;

//Attacking
public float timeBetweenAttacks;
bool alreadyAttacked;

//States
public float sightRange, attackRange;
public bool playerInSightRange, playerInAttackRange;

private void awake()
{
    player = GameObject.Find("JohnLemon").transform;
    agent = GetComponent<NavMeshAgent>();
}

private void Update()
{
    //Check for player in sight and attack range
    playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
    playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

    if (!playerInSightRange && !playerInAttackRange) Patrolling();
    if (playerInSightRange && !playerInAttackRange) ChasePlayer();
    if (playerInAttackRange && playerInSightRange) AttackPlayer();
    {
        
    }
}

private void Patrolling()
{

}

private void ChasePlayer()
{

}

private void AttackPlayer()
{

}