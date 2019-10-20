using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
This class manages aids ObjPooling  by disabling any previously active pooled object in the pool, to hide them from the player
Explanation:
 
Usage:
    - Best used further ahead of the end of a tile/obj, so that whenever the player passes the tile and goes further away from it, the tile deactivates
    - Hide unused objects
Integration:

Implement Later:

 */
public class CnvMechObjPoolTrigDeact : MonoBehaviour
{

	
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            transform.parent.gameObject.SetActive(false);
            transform.parent.transform.position = CnvMechObjPoolMan.instance.hiddenPos;

  
        }
    }
}
