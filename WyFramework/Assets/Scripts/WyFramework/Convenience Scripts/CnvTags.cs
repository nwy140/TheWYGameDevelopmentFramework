using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

public class CnvAnimTags // animation tags
{
    public const string WALK = "Walk";




    public const  string ATTACK_1_TRIGGER = "Attack1";
    public const  string ATTACK_2_TRIGGER = "Attack2";
    public const  string ATTACK_3_TRIGGER = "Attack3";

    public const  string IDLE_ANIMATION = "Idle";

    public const  string KNOCK_DOWN_TRIGGER = "KnockDown";
    public const  string STAND_UP_TRIGGER = "Standup";
    public const  string HIT_TRIGGER = "Hit";
    public const  string DEATH_TRIGGER = "Death";
    public const  string JUMP_TRIGGER = "Jump";

    public const  string GROUND_BOOL = "grounded";

}

public class CnvAxisTags {
    public const string HORIZONTAL_AXIS = "Horizontal";
    public const string VERTICAL_AXIS = "Vertical";
}

public class CnvGenTags { // general tags
    public const string GROUND_TAG = "Grounds";
    public const string PLAYER_TAG = "Player";
    public const string ENEMY_TAG = "Enemy";

    public const string LEFT_ARM_TAG = "LeftArm";
    public const string LEFT_LEG_TAG = "LeftLeg";
    public const string UNTAGGED_TAG = "Untagged";
    public const string MAIN_CAMERA_TAG = "MainCamera";
    public const string HEALTH_UI = "HealthUI";

    public const string ITEM_WEAPON = "ItemWeapon";

}