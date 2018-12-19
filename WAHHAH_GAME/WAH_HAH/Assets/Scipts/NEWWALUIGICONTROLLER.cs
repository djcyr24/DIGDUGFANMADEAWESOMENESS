using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NEWWALUIGICONTROLLER : MonoBehaviour {

    enum Direction { left, right, up, down }

    const float animationTimeCooldown = .65f;
    bool isAttacking;
    float attackCooldown;


    Vector2 direction = Vector2.right;
    float rayDistance = .45f;


    Animator dAnimator;
    Rigidbody2D rb;


    void Start () {
		
	}
	
	void Update () {
		
	}
}
