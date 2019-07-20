using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
This class makes this gameObj follow the axis of a targeted GameObj, to make this Obj align to the target...
Explanation:
 
Usage:
    - Useful when aligning gameObjs such as Characters and Props to a lane in an Endless Runner
Integration:
    - Attach this script to a gameObj
    - Set target in Inspector
    - Set which Axis to Lock in inspector

Implement Later:

 */
public class CnvFollowAxisOfTarget : MonoBehaviour
{
    public GameObject target;
    public bool lockXaxis;
    public bool lockYaxis;
    public bool lockZaxis;



    // Update is called once per frame
    void Update()
    {
        float followPosX = target.transform.position.x;
        float followPosY = target.transform.position.y;
        float followPosZ = target.transform.position.z;
        if(!lockXaxis){
            followPosX = transform.position.x;
        }
        if(!lockYaxis){
            followPosY = transform.position.y;

        }
        if(!lockZaxis){
            followPosZ = transform.position.z;

        }
        transform.position = new Vector3(followPosX,followPosY,followPosZ);


    }
}
