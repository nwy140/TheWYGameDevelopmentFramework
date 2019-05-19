using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechExtraSideScrollerGenericAttack : MonoBehaviour
{
    public float damage;
    public float damageRate;
    public float pushBackForce;

    float nextDamage; // time when damage is possible

    bool playerInRange = false;

    GameObject targetObj;
    MechCharStatHP mechCharStatHP;

    // Start is called before the first frame update
    void Start()
    {
        nextDamage = Time.time;
        targetObj = GameObject.FindGameObjectWithTag("Player");
        mechCharStatHP = targetObj.GetComponent<MechCharStatHP>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            Attack();
        } 
    }


    void Attack(){
        if(mechCharStatHP != null){
            if(nextDamage<= Time.time){
                mechCharStatHP.ApplyDamage(damage);
                nextDamage = Time.time + damageRate;
                
                pushback(targetObj.transform);
            }
        }
    }

    void pushback(Transform pushedObject){
        Vector3 pushDirection = new Vector3(0, (pushedObject.position.y - transform.position.y),0 ).normalized; // normalized returns unit vector
        pushDirection*=pushBackForce;

        Rigidbody pushedRB = pushedObject.GetComponent<Rigidbody>();
        pushedRB.velocity = Vector3.zero;
        pushedRB.AddForce(pushDirection, ForceMode.Impulse); // impulse is the explosive type of force

    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){ // issue with nested collider on older unity versions, so we do it this way
            playerInRange = true;
        }    
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player"){ // issue with nested collider on older unity versions, so we do it this way
            playerInRange = false;
        }           
    }

}