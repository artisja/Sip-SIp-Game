using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("ab testing!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.05f, 0f, 0f);  
    }
}

