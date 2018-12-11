using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyleController : MonoBehaviour {

    public Vector2 tilePos;


	void Start () {
		
	}
	
	void Update () {

        tilePos = GetComponent<Transform>().position;
        //Constant of 0.561 on the X
        if ((tilePos.x == -5.439f) && (tilePos.y == 2.0128f))
        {
            Destroy(gameObject);
        }
        if ((tilePos.x > -4.88f && tilePos.x < -4.87f) && (tilePos.y > 2.01f && tilePos.y < 2.02))
        {
            Destroy(gameObject);
        }
        if ((tilePos.x == 2.414999) && (tilePos.y == -0.7932f))
        {
            Destroy(gameObject);
        }
        if ((tilePos.x == 3.536999f) && (tilePos.y == -0.7932f))
        {
            Destroy(gameObject);
        }
        if ((tilePos.x == 2.975999f) && (tilePos.y == -0.7932f))
        {
            Destroy(gameObject);
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Waluigi")
        {
            if(gameObject.name =="RockSupport")
            {
                GameFlow.supportGone = "y";
                //Debug.Log("success");
            }

            Destroy(gameObject);
        }

    }
}
