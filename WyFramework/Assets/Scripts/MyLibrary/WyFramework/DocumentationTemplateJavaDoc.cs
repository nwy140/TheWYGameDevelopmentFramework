namespace WYFramework{
	//Class 
	
	/**
	This class explain and describes how the documentation of the Wy framework works.
     
	Explanation:
     
	Usage:

	Integration:

	Implement Later:

	*/
	public class DocumentationTemplateJavaDoc
	{

		/**
		Movement Speed of the Character
		Explanation:
		Usage:
		- set this value to influence the speed of the character
                
		Integration:
		- Set a value for this variable in the inpsector
		- Value may change at runtime
		*/
        
		private float examplefloatVariable;
		/**
		functionExample
		Explanation:
		Usage:
		- a
		Integration:
		- w
		* @param  Description of method's or function's input parameter
		* @param  ...
		* @return Description of the return value
		*/
		public float functionExample(string param1){
			return 0;
	    	
		}
        
        
	}
}



/* Archive


// NWY Framework class naming convention

// Cnv for Convenience scripts 
    // for things that help speed up level design and provides convenience
    // e.g tags class that store a bunch of strings, DeactivateGameObjectByTime class that disable an object after a specific amount of time
// Mech for Mechanics scripts
    // for things that affect game world and gameplay
    // e.g flying.cs that allows your character  to fly
// Vis for visual scripts
    // for things that affect the visual aspect of the game
    // e.g character animations class that can call animations to be played
    
    
    
    
    

## Framework Convention



## Naming Convention

- Class Hierachy

  - CharScripts

    - Mech 

      - mechanics
        - e.g movement, ground detection

      - Char
        - character : Anything that has anything to do with NPCs and Playable Characters
          - e.g An

      - Extra
        - extra mechanics libraries that adds more functionality and mechanics to the game

    - Vis 

      - visual
        - e.g Char Animations

  Cvn

  -  convenience
    - e.g Camera, deactive game object by timer, LockPosToObject, tags
*/