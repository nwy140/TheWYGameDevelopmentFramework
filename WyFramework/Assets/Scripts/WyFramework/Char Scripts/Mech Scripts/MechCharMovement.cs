using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MechCharMovement : MonoBehaviour
{
	Rigidbody2D myRB;
	// VisCharAnim childVisCharAnim;
	public MechActorGroundDetector MechActorGroundDetector;
	public float runSpeed;
	public float jumpSpeed;
	public bool flipChildChar;


	// Start is called before the first frame update
	void Awake()
	{
		myRB = GetComponent<Rigidbody2D>();
//		childVisCharAnim = GetComponentInChildren<VisCharAnim>();

	}

	// Update is called once per frame
	void Update()
	{
		TapVerticalMovement();
		ManualHorizontalMovement();

	}

	void ManualHorizontalMovement()
	{
		myRB.velocity = new Vector2((runSpeed * Input.GetAxis("Horizontal") * Vector2.right).x, myRB.velocity.y);
		
		if (myRB.velocity.x > 0.2f)
		{
		
		}
		else if (myRB.velocity.x < -0.2f)
		{

		}
		else
		{

		}
	}

	void AutoHorizontalMovement()
	{
		myRB.velocity += new Vector2(runSpeed, 0);

	}

	void TapVerticalMovement()
	{
		if (Input.GetButton("Fire1"))
		{
			if (MechActorGroundDetector.isGrounded == true)
			{
				myRB.velocity = new Vector2(myRB.velocity.x, (jumpSpeed * Input.GetAxis("Fire1") * Vector2.up).y);
			}
		}
	}
	
	
	
}


   