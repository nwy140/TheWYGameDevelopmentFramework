using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    public bool isGrounded;
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D other) {
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
