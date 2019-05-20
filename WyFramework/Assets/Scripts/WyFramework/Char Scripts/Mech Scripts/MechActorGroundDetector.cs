using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechActorGroundDetector : MonoBehaviour
{
    public bool isGrounded;
    // Start is called before the first frame update
    
    // add new collision layer as 8 for ground detection

    private void OnTriggerEnter2D(Collider2D other) {
        if(LayerMask.LayerToName(other.gameObject.layer) == "PropCol" ){
            isGrounded = true;        
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(LayerMask.LayerToName(other.gameObject.layer) == "PropCol" ){
            isGrounded = false;      
        }
    }   
}


// old get layer         if(other.gameObject.layer == 8 ){
