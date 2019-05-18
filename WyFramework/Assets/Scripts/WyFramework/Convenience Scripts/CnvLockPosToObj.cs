using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CnvLockPosToObj : MonoBehaviour
{

	public Transform objTarget;
	public Vector3 posOffset;
	
	// Update is called once per frame
	void Update ()
	{

		gameObject.transform.position = objTarget.position + posOffset;

	}
}
