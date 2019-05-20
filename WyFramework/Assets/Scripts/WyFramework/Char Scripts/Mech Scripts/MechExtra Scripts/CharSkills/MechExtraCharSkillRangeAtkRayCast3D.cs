using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechExtraCharSkillRangeAtkRayCast3D : MonoBehaviour
{
    public float range = 10f;
    public float damage = 5f;

    Ray shootRay;
    RaycastHit shootHit; //Anything that's hit by the raycast
    int shootableMask;
    LineRenderer gunLine;

    // Start is called before the first frame update
    void Update()
    {
        shootableMask = LayerMask.GetMask("PropCol");
        gunLine = GetComponent<LineRenderer>(); 

        shootRay.origin = transform.position;  
        shootRay.direction = transform.forward;
        gunLine.SetPosition(0,transform.position);

        if(Physics.Raycast(shootRay, out shootHit, range, shootableMask)){
            //hit an enemy goes here
            gunLine.SetPosition(1,shootHit.point); // draw line from position of fired all the way to hit point
        } else gunLine.SetPosition(1,shootRay.origin + shootRay.direction * range);
//        shootHit.collider.GetComponent<MechCharStatHP>().ApplyDamage(damage);
    }   


}
