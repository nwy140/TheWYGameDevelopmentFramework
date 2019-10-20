using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
This class reuses a disabled pooled Object in the pool by activating the, and placing them at the intended "Spawn" location, to simulate a spawning , without instantiating a new instance of the object, to save on performance
Explanation:
 
Usage:
    - Best used in Endless Games including Runners
    - Can be used for weapon projectiles too or NPCs in a game 
Integration:

Implement Later:

 */
public class CnvMechObjPoolTrigSpwn : MonoBehaviour
{
	private CnvMechObjPoolMan OP;
    // private GameObject player;
 //   private GameManager GM;
    [SerializeField]
    private int poolIndex = 0;
    public int numberOfTilesToSpawn = 2;
    public Transform spawnPoint;
    public Vector3 spawnOffset;
    public GameObject LanePoints;
    private Vector3 newSpawnOffset; // only used for new tiles that are placed in world
    private GameObject player;

    public bool itemConsumed = false;

    void Start()
    {
        if(CnvMechObjPoolMan.instance)
            OP = CnvMechObjPoolMan.instance;
  //      if(GameManager.instance)
  //          GM = GameManager.instance;
        if(player){
            player = GameObject.FindGameObjectWithTag("Player");

        }
        
    }

    void OnEnable() {
        itemConsumed = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) {
            if(other.tag == "Player" && itemConsumed == false){
                print(transform.parent.gameObject.name + "triggered" );

                poolIndex = Random.Range(0, OP.Pool.Count-1);
                newSpawnOffset = spawnOffset;
                for(int i = 0; i<numberOfTilesToSpawn; i++){
                    newSpawnOffset *= i+1;
                    // ShuffleList(OP.Pool);
                    ManagePooling();
                } 
                newSpawnOffset = spawnOffset;
            }

    }    
    
    void ManagePooling(){
        GameObject spawnedObj = OP.GetPooledObjectRandom();
        if (spawnedObj != null) {
            spawnedObj.transform.position = spawnPoint.position + spawnOffset;
            spawnedObj.transform.rotation = Quaternion.identity;
            spawnedObj.SetActive(true);
        }
  //      if(GM)
 //           GM.IncreaseScore(1);

        itemConsumed = true;
    }


}


/* Old Implementation

            int poolIndex = Random.Range(0, OP.Pool.Count);

            if(OP.Pool[poolIndex].active){
                OP.Pool.Add(Instantiate(OP.Pool[poolIndex],spawnPoint.position, Quaternion.identity));
                print("Adding");               
            } else{
                OP.PutObjectInWorld(poolIndex, spawnPoint.position);
            } 
            
            
*/