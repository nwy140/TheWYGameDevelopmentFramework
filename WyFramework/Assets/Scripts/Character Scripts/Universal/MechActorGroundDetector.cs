using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechActorGroundDetector : MonoBehaviour
{
    public bool isGrounded;
    // Start is called before the first frame update
    
    // add new collision layer as 8 for ground detection

    private void OnTriggerEnter2D(Collider2D other) {
        print("Det" + other.gameObject.layer);
        if(other.gameObject.layer == 8 ){
            isGrounded = true;        
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.layer == 8 ){
            isGrounded = false;      
        }
    }   
}
