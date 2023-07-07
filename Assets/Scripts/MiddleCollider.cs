using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MiddleCollider : MonoBehaviour
{
    private Logic logicScript;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {

    }


}
