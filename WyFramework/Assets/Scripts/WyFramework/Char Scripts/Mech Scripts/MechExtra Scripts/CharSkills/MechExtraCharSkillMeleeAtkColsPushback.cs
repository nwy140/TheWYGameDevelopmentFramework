using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*

*/
///<summary> 
///     This class uses a collider that apply damage to any character that touches it, and push them back in recoil 
///     Explanation:

/// 		
///     Usage:

/// 		
///     Integration:

/// 
/// </summary>
public class MechExtraCharSkillMeleeAtkColsPushback : MonoBehaviour // melee attack collision
{
    public float damage;
    public float damageRate;
    public float pushBackForce;

    float nextDamageTime; // time when damage is possible


    // Start is called before the first frame update
    void Start()
    {
        nextDamageTime = Time.time;

    }



    void Attack(GameObject targetObj)
    {

        MechCharStatHP targetMechCharStatHP = targetObj.GetComponent<MechCharStatHP>();
        
        if(targetMechCharStatHP != null){
            if(nextDamageTime<= Time.time){
                targetMechCharStatHP.ApplyDamage(damage);
                nextDamageTime = Time.time + damageRate;
                
                pushback(targetObj.transform);
            }
        }
    }

    void pushback(Transform pushedObject){
        Vector3 pushDirection = new Vector3(0, (pushedObject.position.y - transform.position.y),0 ).normalized; // normalized returns unit vector
        pushDirection*=pushBackForce;

        Rigidbody2D pushedRB = pushedObject.GetComponent<Rigidbody2D>();
        pushedRB.velocity = Vector3.zero;
        pushedRB.AddForce(pushDirection, ForceMode2D.Impulse); // impulse is the explosive type of force

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject)
        {
            Attack(other.gameObject);
        }
    }


}