using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask ennemyLayers;
    public float attackRate = 2f;
    private float nextAttackTime = 0;

  
    void Update()
    {
        if(Time.time >= nextAttackTime )
        if (Input.GetKeyDown(KeyCode.E)) {

            Attack();
                nextAttackTime = Time.time + 1f / attackRate;
        }

        
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnnemies = Physics2D.OverlapCircleAll(attackPoint.position,attackRange,ennemyLayers);

        foreach(Collider2D ennemy in hitEnnemies)
        {
            Debug.Log(" We hit " + ennemy.name);
        }


    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
