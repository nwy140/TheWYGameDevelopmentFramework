using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*

*/
///<summary> 
///     This class uses a collider that apply damage to any character that touches it, and push them back in recoil
///         
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
                
                MechExtraCharSkillPhysicsShortcuts.pushback(targetObj.transform,transform, pushBackForce);
            }
        }
    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject)
        {
            Attack(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject)
        {
            Attack(other.gameObject);
        }
        
    }
}