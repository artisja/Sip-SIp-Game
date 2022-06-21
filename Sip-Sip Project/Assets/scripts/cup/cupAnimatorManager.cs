using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * handles animation triggers and level triggers for game
 * **/
public class cupAnimatorManager : MonoBehaviour
{
    //gameobject variable 
    private GameObject gO = null;

    //animator objct variable
    private Animator objectAnimator = null;

    //level activated boolean

    private bool levelActivated = false;

    //init cup sprite to be used by animation manager script
    public void initCupSprite()
    {
        this.gO = gameObject;
        this.getAnimator();
    }

    //activates trigger and animation
    public void processClickInput()
    {
        if (this.objectAnimator != null) {
            var triggerParam = this.objectAnimator.GetParameter(0);
            this.objectAnimator.SetTrigger(triggerParam.nameHash);
            this.levelActivated = true;
                   
        }
        
    }

    //tests if mouse has clicked current game object
    public bool clickedObjectVerification() {
        RaycastHit hit;
        bool objectClicked = false;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "cup")
            {
                objectClicked = true;
            }
        }
        return objectClicked;
    }

    //gets the animator controller on this game object
    private void getAnimator() {
        if (this.gO != null) {
            if (this.gO.GetComponent<Animator>() != null) {
                this.objectAnimator = this.gO.GetComponent<Animator>();
            }
        }
    }

    //returns if levelActivated var
    public bool isLevelActivated() {
        return this.levelActivated;
    }

    //sets levelactivated to false
    public void resetLevelTrigger() {
        this.levelActivated = false;
    }
}
