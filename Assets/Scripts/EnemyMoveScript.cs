using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveScript : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private EnemyAggroScript enemyAggroScript;
    private Transform target;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        enemyAggroScript = GetComponent<EnemyAggroScript>();
        enemyAggroScript.OnAggro += EnemyAggroScript_OnAggro;
    }

    private void EnemyAggroScript_OnAggro(Transform target)
    {
        this.target = target;
        //navMeshAgent.SetDestination(target.position);
    }

    private void Update()
    {
        if(target != null)
        {
            navMeshAgent.SetDestination(target.position);

            float currentspeed = navMeshAgent.velocity.magnitude;
            animator.SetFloat("Speed", currentspeed);
        }
    }
}
