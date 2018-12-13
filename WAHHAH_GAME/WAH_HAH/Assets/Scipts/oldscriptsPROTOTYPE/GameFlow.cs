using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour {

    public Transform dirt1Obj;
    public Transform dirt2Obj;
    public Transform dirt3Obj;
    public Transform dirt4Obj;
    public Transform dirtBGobj;

    public static string supportGone = "n";

    void Start () {
        //Constant of 0.561 on the X
        for (float xPos = -6f; xPos < 6; xPos+= 0.561f)
        {
            //Ground1
            Instantiate(dirt1Obj, new Vector2(xPos, 2.574f), dirt1Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos, 2.574f), dirtBGobj.rotation);

            Instantiate(dirt1Obj, new Vector2(xPos, 2.0128f), dirt1Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos, 2.0128f), dirtBGobj.rotation);
            //Ground2
            //CONSTANT OF 0.5612 on Y
            Instantiate(dirt2Obj, new Vector2(xPos, 1.4516f), dirt2Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos, 1.4516f), dirtBGobj.rotation);

            Instantiate(dirt2Obj, new Vector2(xPos, 0.8904f), dirt2Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos, 0.8904f), dirtBGobj.rotation);

            //Ground 3
            Instantiate(dirt3Obj, new Vector2(xPos, 0.3292f), dirt3Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos, 0.3292f), dirtBGobj.rotation);

            Instantiate(dirt3Obj, new Vector2(xPos, -0.232f), dirt3Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos, -0.232f), dirtBGobj.rotation);

            Instantiate(dirt3Obj, new Vector2(xPos, -0.7932f), dirt3Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos, -0.7932f), dirtBGobj.rotation);


            //Ground 4
            Instantiate(dirt4Obj, new Vector2(xPos, -1.3544f), dirt4Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos, -1.3544f), dirtBGobj.rotation);

            Instantiate(dirt4Obj, new Vector2(xPos, -1.9156f), dirt4Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos, -1.9156f), dirtBGobj.rotation);

            Instantiate(dirt4Obj, new Vector2(xPos, -2.4768f), dirt4Obj.rotation);
            Instantiate(dirtBGobj, new Vector2(xPos,-2.4768f), dirtBGobj.rotation);

        }


    }

    void Update () {
		
	}
}
