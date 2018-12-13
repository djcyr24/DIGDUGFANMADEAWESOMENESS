using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour {

	void Start ()
    {
        GetComponent<PolygonCollider2D>().enabled = false;
	}
	
	void Update ()
    {
        GetComponent<PolygonCollider2D>().enabled = true;

        if (GameFlow.supportGone == "y")
        {
            StartCoroutine(dropRock());
            GameFlow.supportGone = "n";
        }
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    IEnumerator dropRock()
    {
        yield return new WaitForSeconds(3);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
