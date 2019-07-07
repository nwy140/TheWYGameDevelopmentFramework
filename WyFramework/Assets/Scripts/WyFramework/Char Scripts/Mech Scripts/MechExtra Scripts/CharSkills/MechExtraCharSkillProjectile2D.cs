using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary> 
///     This class adds force to a gameObj and blast it away like a projectile. The Projectile has a collider that apply damage to any character that touches it, and push them back in recoil
///         
///     Explanation:

/// 		
///     Usage:

/// 		
///     Integration:

///
///     Implement Later:
///     - Add Pushback force 
/// 
/// </summary>
/// 
public class MechExtraCharSkillProjectile2D : MonoBehaviour
{
    public float damage;
    public float speed;

    Rigidbody2D myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        if(transform.rotation.y>0) {
            myRB.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        }
        else myRB.AddForce(Vector2.right *-speed, ForceMode2D.Impulse);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Shootable"))
        {
            MechCharStatHP mechCharStatHP = other.GetComponent<MechCharStatHP>();
            mechCharStatHP.ApplyDamage(damage);
            myRB.velocity = Vector2.zero;
            Destroy(gameObject);
        }    
    }
}
