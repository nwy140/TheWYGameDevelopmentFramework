using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary> 
///     This class sets a timer in game, that will keep counting down in real time
///     Explanation:

/// 		
///     Usage:

/// 		
///     Integration:

///
///     Implement Later: 
/// 
/// </summary>
///
/// 
public class MechExtraWorldStatTimer : MonoBehaviour {
    public float currentCountDownTimer = 100f;
    public Text StatTimerText;
    public Slider StatTimerSlider;

    private float initCountDownTimer;
    private void Awake()
    {
        initCountDownTimer = currentCountDownTimer;
    }

    void Update()
    {
        currentCountDownTimer -= Time.deltaTime;
        
        StatTimerText.text = Mathf.RoundToInt(currentCountDownTimer).ToString();
        StatTimerSlider.value = currentCountDownTimer / initCountDownTimer;

    }
    
}
