using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CnvDeactiveGmObjByTime : MonoBehaviour
{

    public float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeactivateAfterTime",timer);
    }

    // Update is called once per frame
    void DeactivateAfterTime()
    {
        gameObject.SetActive(false);
        
    }
}