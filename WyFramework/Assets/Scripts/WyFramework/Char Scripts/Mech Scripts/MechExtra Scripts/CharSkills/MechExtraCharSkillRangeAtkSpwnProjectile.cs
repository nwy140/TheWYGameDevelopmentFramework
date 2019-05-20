﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MechExtraCharSkillRangeAtkSpwnProjectile : MonoBehaviour
{
    public float timeBetweenBullets = 0.15f;

    public GameObject projectile;
    // public Slider playerAmmoSlider;
    public int maxRounds;
    public int startingRounds;
    public int roundsPerShot = 1;
    [SerializeField]
    int remainingRounds;
    float nextBullet;
    Animator myAnim;

    //audio info
    AudioSource gunMuzzleAS;    
    public AudioClip shootSound;
    public AudioClip reloadSound;

    // Start is called before the first frame update
    void Awake()
    {
        nextBullet = 0f;
        remainingRounds = startingRounds;
        // playerAmmoSlider.maxValue = maxRounds;
        // playerAmmoSlider.value = remainingRounds;
        gunMuzzleAS = GetComponent<AudioSource>();
        myAnim = transform.root.GetComponentInChildren<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(2)){
            useWeapon();

        }


    }
    public void useWeapon(){
        if(nextBullet < Time.time && remainingRounds>0){  // LMB
            nextBullet = Time.time + timeBetweenBullets; // increase time between bullets for weapon delay
            myAnim.SetTrigger("gunShoot");
            for(int i = 0; i<roundsPerShot; i++){
                Vector3 rot;
                if(myAnim.GetCurrentAnimatorStateInfo(0).IsName("Movement")){
                    rot = transform.forward;
                } else{
                    rot = transform.rotation.ToEuler();
                }
                Instantiate(projectile, transform.position,Quaternion.Euler(rot));
                playASound(shootSound);
                remainingRounds -=1;
                // playerAmmoSlider.value = remainingRounds;

            }
        }
    }

    public void reload(){
        remainingRounds = maxRounds;
        // playerAmmoSlider.value = remainingRounds;

        playASound(reloadSound);
    }

    void playASound(AudioClip playTheSound){
        gunMuzzleAS.clip = playTheSound;
        gunMuzzleAS.Play();
    }
}