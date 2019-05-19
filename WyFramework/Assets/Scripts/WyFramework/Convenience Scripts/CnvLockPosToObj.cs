using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CnvLockPosToObj : MonoBehaviour
{

	public Transform objTarget;
	public Vector3 custPosOffset;
	public bool bUseOriginalPosAsOffset;

	private Vector3 originalPos;
	private void Awake()
	{
		originalPos = transform.localPosition;
	}

	// Update is called once per frame
	void Update ()
	{

		if (bUseOriginalPosAsOffset)
		{
			gameObject.transform.position = objTarget.position + originalPos;
		}
		else
		{
			gameObject.transform.position = objTarget.position + custPosOffset;
		}

	}
}
