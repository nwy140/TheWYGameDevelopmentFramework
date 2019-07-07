using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 	Info: This class detects if a gameObject is touching a Prop with Collision on it
///     Integration:
///         - Attach a collision and a rigidbody to a gameObject
///         - Set the gameObject's LayerMask to "PropCol"
///     Usage:
///         - Access a reference to a gameObj with this script attached
///         - Get the isGrounded boolean from it and integrate with your gameplay Logic
/// 
/// </summary>


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
