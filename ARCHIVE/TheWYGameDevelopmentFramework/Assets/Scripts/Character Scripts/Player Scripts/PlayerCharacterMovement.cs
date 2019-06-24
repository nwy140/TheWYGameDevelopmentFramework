using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCharacterMovement : MonoBehaviour
{
	Rigidbody2D myRB;
	CharacterAnimation childCharAnim;
	GroundDetector childGD;
	public float runSpeed;
	public float jumpSpeed;
	public bool flipChildChar;


	// Start is called before the first frame update
	void Awake()
	{
		myRB = GetComponent<Rigidbody2D>();
		childCharAnim = GetComponentInChildren<CharacterAnimation>();
		childGD = GetComponentInChildren<GroundDetector>();
		

		if(flipChildChar){
			childCharAnim.transform.localRotation = Quaternion.Euler(0,180,0);
		}else{
			childCharAnim.transform.localRotation = Quaternion.Euler(0,0,0);
		}	
	}

	// Update is called once per frame
	void Update()
	{
		TapVerticalMovement();
		ManualHorizontalMovement	();

	}

	void ManualHorizontalMovement() {
		myRB.velocity = new Vector2 ((runSpeed * Input.GetAxis("Horizontal") * Vector2.right).x, myRB.velocity.y);
		if (myRB.velocity.x > 0.2f) {
			childCharAnim.Walk(true);
			if(flipChildChar){
				childCharAnim.transform.localRotation = Quaternion.Euler(0,180,0);
			}else{
				childCharAnim.transform.localRotation = Quaternion.Euler(0,0,0);
			}			
		} else if (myRB.velocity.x < -0.2f) {
			childCharAnim.Walk(true);	
			if(flipChildChar){
				childCharAnim.transform.localRotation = Quaternion.Euler(0,0,0);
			}else{
				childCharAnim.transform.localRotation = Quaternion.Euler(0,180,0);
			}
		} else {
			childCharAnim.Walk(false);
			
		}
	}

	void AutoHorizontalMovement() {
		myRB.velocity += new Vector2(runSpeed, 0);
		
	} 

    void TapVerticalMovement(){
        if(Input.GetButton("Fire1")){
            if(childGD.isGrounded == true){ // jump only when grounded
                childCharAnim.Jump();
				myRB.velocity = new Vector2 (myRB.velocity.x, (jumpSpeed *  Input.GetAxis("Fire1") * Vector2.up).y );

            }
        }
    }


    private void OnCollisionEnter(Collision other) {
        
    }
}
