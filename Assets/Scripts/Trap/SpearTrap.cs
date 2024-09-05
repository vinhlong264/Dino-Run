using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpearTrap : TrapSpecial
{
    [SerializeField] private Transform attackCheck;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask mask;
    
    protected override void Start()
    {
        base.Start();
        StartCoroutine(AnimtorAttack(2));
    }


    IEnumerator AnimtorAttack(float _second)
    {
        while (true)
        {
            anim.SetBool("isAttack", true);
            yield return new WaitForSeconds(_second);
            anim.SetBool("isAttack", false);
        }
    }


    private void AnimationTrigger()
    {
        Collider2D hit = Physics2D.OverlapCircle(attackCheck.position, radius, mask);
        if(hit != null)
        {
            hit.GetComponent<Dino>().Die();
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(attackCheck.position, radius);
    }



}
