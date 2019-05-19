using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechExtraCharSkillProjectile : MonoBehaviour
{
    public float damage;
    public float speed;

    Rigidbody myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        if(transform.rotation.y>0) {
            myRB.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }
        else myRB.AddForce(Vector3.forward *-speed, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.layer == LayerMask.NameToLayer("Shootable")){
            MechCharStatHP mechCharStatHP = other.GetComponent<MechCharStatHP>();
            mechCharStatHP.ApplyDamage(damage);
            myRB.velocity = Vector2.zero;
            Destroy(gameObject);
        }
    }
}
