using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    //animator manager script for cup object
    //provides level activation variable
    private cupAnimatorManager cIm = null;
    private levelManager lm = null;
    //current cup object
    public GameObject cupSprite = null;

    // Start is called before the first frame update
    //get the animator manager script and init the cupsprite
    void Start()
    {
        this.cIm = this.cupSprite.GetComponent<cupAnimatorManager>();
        this.cIm.initCupSprite();
        this.lm = gameObject.GetComponent<levelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //mouse click input check
        if (Input.GetMouseButtonDown(0))
        {
            //handles cIm script interaction, checks/sets if level was activated by cup click
            if (this.cIm != null)
            {
                if (!this.cIm.isLevelActivated() && this.cIm.clickedObjectVerification()) {
                    this.cIm.processClickInput();
                    this.lm.setLevelTransitionTrigger(this.cIm.isLevelActivated());
                }
            }
        }    
    }
}
