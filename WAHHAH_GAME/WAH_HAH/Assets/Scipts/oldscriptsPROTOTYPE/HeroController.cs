using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

    public float xVel = 0;
    public float yVel = 0;
    float xRotate;

	void Start () {
		
	}

    void Update()
    {
        xVel = Input.GetAxis("Horizontal");
        yVel = Input.GetAxis("Vertical");
        xRotate = 90;

        if (xVel > 0)
        {
            yVel = 0;
            transform.rotation = Quaternion.Euler(0, 180, 0);

        }
        if (yVel > 0)
        {
            xVel = 0;

            transform.rotation = Quaternion.Euler(0, 0, xRotate + 180);
        }
        if (xVel < 0)
        {
            yVel = 0;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        if (yVel < 0)
        {
            xVel = 0;

            transform.rotation = Quaternion.Euler(0, 0, xRotate);
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(2 * xVel, 2 * yVel);


    }
}
