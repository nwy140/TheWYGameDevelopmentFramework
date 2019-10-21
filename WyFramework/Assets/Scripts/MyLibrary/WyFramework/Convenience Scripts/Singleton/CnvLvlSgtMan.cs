using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
	
	// Example Doxygen Documentation Convention
	/**
	 * @file
	 * @author  John Doe <jdoe@example.com>
	 * @version 1.0
	 * @section DESCRIPTION
	 *
	 * The time class represents a moment of time.
	 */
public class CnvLvlSgtMan : MonoBehaviour
{

	public static CnvLvlSgtMan instance;
	    
	public float GameplayTimeScale = 1;
	

    public void Awake()
    {
	    MakeInstance();
	    
	    // default gameplay timeScale
	    Time.timeScale =  GameplayTimeScale;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))    
        {
            LoadLevelByIndex(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            LoadLevelByIndex(1);

        }
        //Always show mouse on Menu

	    // cheats // 
	    if(Input.GetKeyDown(KeyCode.RightBracket)){
	    	cheatIncreaseTimeScale();
	    } else if(Input.GetKeyDown(KeyCode.LeftBracket)){
	    	cheatDecreaseTimeScale();
	    }
	    
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void LoadLevel(string Name)
    {
        Debug.Log("Level Load requeted for : " + Name);
        SceneManager.LoadScene(Name);

    }

    public void RestartLevel()
    {
        Debug.Log("Level Load requeted for : " + "Restart Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


    public void RequestQuit()
    {
        Debug.Log("I want to quit");
        Application.Quit();

    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLevelByIndex(int index)
    {
        Debug.Log("Level Load requeted for index : " + index);
        SceneManager.LoadScene(index);

        // show mouse on menu


    }

    public void ShowMouse()
    {

        Cursor.visible = true;


    }

    public void PauseLevel()
	{
		if(CnvAltGameplayMan.instance){
			CnvAltGameplayMan.instance.gameplayState = CnvAltGameplayMan.GameplayState.GAME_PAUSE;
		}
        Time.timeScale = 0;
        CnvAltGameplayMan.instance.gameplayState = CnvAltGameplayMan.GameplayState.GAME_PAUSE;
    }

    public void unPauseLevel()
	{
		if(CnvAltGameplayMan.instance){
			CnvAltGameplayMan.instance.gameplayState = CnvAltGameplayMan.GameplayState.GAME_RUNNING;
		}
	    Time.timeScale =  GameplayTimeScale;
        CnvAltGameplayMan.instance.gameplayState = CnvAltGameplayMan.GameplayState.GAME_RUNNING;
    }
	
	public void setGameplayTimeScale(float timeScaleVal){
		GameplayTimeScale = timeScaleVal;
		
		
	}

	public void cheatIncreaseTimeScale(){
		GameplayTimeScale++;
		Time.timeScale = GameplayTimeScale;
	}
	public void cheatDecreaseTimeScale(){
		GameplayTimeScale--;
		Time.timeScale = GameplayTimeScale;
	}
}
