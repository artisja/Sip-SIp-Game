using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * level manager for game. Handles all level transitions
 * **/
public class levelManager : MonoBehaviour
{
    //trigger to activate level
    private bool levelTransitionActivated = false;

    //sets level trigger
    public void setLevelTransitionTrigger(bool value) {
        this.levelTransitionActivated = value;
    }

    private void Update()
    {
        
    }
}
