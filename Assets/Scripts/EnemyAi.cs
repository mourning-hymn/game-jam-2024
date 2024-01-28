using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public float attackRate = 4;
    float nextAttack = 0;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
    }
    void Attack()
    {
        anim.SetTrigger("Attack");
    }
    void Update()
    {
        if(Time.time>= nextAttack)
        {
            Attack();
        }
    }

}
