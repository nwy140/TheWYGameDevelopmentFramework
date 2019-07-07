using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary> 
///     This class performs a raycast that detects any Character and apply damage to them, and then push them back in recoil 
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
public class MechExtraCharSkillRangeAtkRayCast2D : MonoBehaviour
{
    public float range = 10f;
    public float damage = 5f;

    RaycastHit2D shootHit; //Anything that's hit by the raycast
    int shootableMask;
    LineRenderer gunLine;

    // Start is called before the first frame update
    void Update()
    {
        shootableMask = LayerMask.GetMask("PropCol");
        gunLine = GetComponent<LineRenderer>();
        gunLine.SetPosition(0,transform.position);

        if(Physics2D.Raycast(transform.position, transform.forward, range, shootableMask)){
            //hit an enemy goes here
            gunLine.SetPosition(1,shootHit.collider.transform.position); // draw line from position of fired all the way to hit point
        } else gunLine.SetPosition(1,shootHit.collider.transform.position + shootHit.collider.transform.forward * range);
//        shootHit.collider.GetComponent<MechCharStatHP>().ApplyDamage(damage);
    }   


}
