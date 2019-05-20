using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechExtraCharSkillMeleeAtkSphrCast : MonoBehaviour // melee atk sphr cast
{
    public float damage;
    public float knockBackRadius;
    public float meleeRate;
    float nextMelee;
    int shootableMask;
    // Animator myAnim;
    public float pushBackForce;

    public bool bIs2DGame = true;
    public bool bDebugTrace = false;
    /// Start is called before the first frame update
    void Start()
    {
        shootableMask = LayerMask.GetMask("PropCol");
//        myAnim = transform.root.GetComponentInChildren<Animator>();    
        nextMelee = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxis("Jump")>0){
            useWeapon();
        }
    }

    public void useWeapon(){
        if(nextMelee < Time.time){
            nextMelee = Time.time + meleeRate;

            //do damage
            if (bIs2DGame) // for 2D Games
            {
                Collider2D[] target = Physics2D.OverlapCircleAll(transform.position, knockBackRadius, shootableMask);

                if (bDebugTrace)
                {
                    DebugExtension.DebugWireSphere(transform.position,Color.red,knockBackRadius);
                }

                foreach (Collider2D tCol in target)
                {
                    
                    MechCharStatHP targetMechCharStatHP = tCol.GetComponent<MechCharStatHP>();
                    if (targetMechCharStatHP)
                    {
                        targetMechCharStatHP.ApplyDamage(damage);
                        pushback(tCol.gameObject.transform);

                    }
                }
                
            }
            
            else // for 3D Games
            {
                Collider[] target = Physics.OverlapSphere(transform.position, knockBackRadius, shootableMask);

                if (bDebugTrace)
                {
                    DebugExtension.DebugWireSphere(transform.position,Color.red,knockBackRadius);
                }
                print(target.Length);

                foreach (Collider tCol in target)
                {
                    MechCharStatHP targetMechCharStatHP = tCol.GetComponent<MechCharStatHP>();
                    if (targetMechCharStatHP)
                    {
                        targetMechCharStatHP.ApplyDamage(damage);
                        pushback(tCol.gameObject.transform);
                    }    
                }


            }
        }
    }
    
    void pushback(Transform pushedObject){
        Vector3 pushDirection = new Vector3(0, (pushedObject.position.y - transform.position.y),0 ).normalized; // normalized returns unit vector
        pushDirection*=pushBackForce;

        if (pushedObject.GetComponent<Rigidbody2D>())
        {
            Rigidbody2D pushedRB = pushedObject.GetComponent<Rigidbody2D>();
            pushedRB.velocity = Vector3.zero;
            pushedRB.AddForce(pushDirection, ForceMode2D.Impulse); // impulse is the explosive type of force
        }


    }
    
}
