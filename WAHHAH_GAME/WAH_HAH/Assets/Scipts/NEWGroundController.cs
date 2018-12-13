using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWGroundController : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Waluigi")
        {
            if (gameObject.name == "RockSupport")
            {
                GameFlow.supportGone = "y";
                //Debug.Log("success");
            }

           // GetComponent<SpriteTileMode>()
        }

    }
}