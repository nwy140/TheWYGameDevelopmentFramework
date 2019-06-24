using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
   private Animator myAnim;
   private GroundDetector externalGD;

    void Awake() {
        myAnim = GetComponent<Animator>();
        externalGD = transform.root.GetComponentInChildren<GroundDetector>();
        
    }

    private void Update() {
        //set anim param for update
        myAnim.SetBool(AnimationTags.GROUND_BOOL,externalGD.isGrounded);
    }

    public void Walk(bool walk){
        myAnim.SetBool(AnimationTags.WALK,walk);
        
    }
    public void Attack1(){
         myAnim.SetTrigger(AnimationTags.ATTACK_1_TRIGGER);
    }
    public void Attack2(){
         myAnim.SetTrigger(AnimationTags.ATTACK_2_TRIGGER);
    }
    public void Attack3(){
         myAnim.SetTrigger(AnimationTags.ATTACK_3_TRIGGER);
    }

    public void Jump(){
         myAnim.SetTrigger(AnimationTags.JUMP_TRIGGER);
    }

    // ENEMY ANIMATIONS
    public void EnemyAttack(int attack){
        if(attack == 0){
            myAnim.SetTrigger(AnimationTags.ATTACK_1_TRIGGER);
        }
        if(attack == 1){
            myAnim.SetTrigger(AnimationTags.ATTACK_2_TRIGGER);
        }
        if(attack == 2){
            myAnim.SetTrigger(AnimationTags.ATTACK_3_TRIGGER);
        }
        
    }

    public void Play_IdleAnimation(){
        
        // Play animation by name
        myAnim.Play(AnimationTags.IDLE_ANIMATION);
    }

    public void KnockDown(){
        myAnim.SetTrigger(AnimationTags.KNOCK_DOWN_TRIGGER);
    }
    
    public void StandUp(){
        myAnim.SetTrigger(AnimationTags.STAND_UP_TRIGGER);
    }
    public void Hit(){
        myAnim.SetTrigger(AnimationTags.HIT_TRIGGER);
    }
    public void Death(){
        myAnim.SetTrigger(AnimationTags.DEATH_TRIGGER);

    }






}
