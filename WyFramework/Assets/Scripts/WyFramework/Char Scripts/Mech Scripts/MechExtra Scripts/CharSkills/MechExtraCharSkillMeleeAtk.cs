using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechExtraCharSkillMeleeAtk : MonoBehaviour
{
    public float damage;
    public float knockBack;
    public float knockBackRadius;
    public float meleeRate;
    float nextMelee;
    int shootableMask;
    Animator myAnim;
    

    /// Start is called before the first frame update
    void Start()
    {
        shootableMask = LayerMask.GetMask("Shootable");
        myAnim = transform.root.GetComponentInChildren<Animator>();    
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
            myAnim.SetTrigger("gunMelee");
            nextMelee = Time.time + meleeRate;

            //do damage

            Collider[] attacked = Physics.OverlapSphere(transform.position,knockBackRadius, shootableMask);
            print(attacked[0].name);
            if(attacked[0].tag != tag){
                attacked[0].GetComponent<MechCharStatHP>().ApplyDamage(damage);
            }

        }
    }
}
