using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/**
This class manages ObjPooling to save performance, by reusing gameObj in a world, to  procedurally generate the level in the game
Explanation:
 
Usage:
    - Best used in Endless Games including Runners
    - Can be used for weapon projectiles too or NPCs in a game 
Integration:

Implement Later:

 */
public class CnvLvlSgtMan : MonoBehaviour {

    public static CnvLvlSgtMan instance;

    public void Awake() {
        MakeInstance();
    }

    void Update() {

        //Always show mouse on Menu

    }
    void MakeInstance() {
        if (instance == null) {
            instance = this;
        }
    }	
    public void LoadLevel (string Name) {	
        Debug.Log ("Level Load requeted for : "+Name);
        Application.LoadLevel (Name); 	
		
    }
	
    public void RestartLevel () {	
        Debug.Log ("Level Load requeted for : "+ "Restart Level");
        Application.LoadLevel (SceneManager.GetActiveScene().name); 	
		
    }
	
	
    public void RequestQuit () {
        Debug.Log ("I want to quit");
        Application.Quit();

    }
    public void LoadNextLevel () {
        Application.LoadLevel (Application.loadedLevel + 1);
    }

    public void LoadLevelByIndex (int index) {	
        Debug.Log ("Level Load requeted for index : " + index);
        Application.LoadLevel (index); 	

        // show mouse on menu

		
    }	

    public void ShowMouse(){
		
        Cursor.visible = true;
		
		
    }

    public void PauseLevel()
    {
        Time.timeScale = 0;
    }

    public void unPauseLevel()
    {
        Time.timeScale = 1;
    }
	

}