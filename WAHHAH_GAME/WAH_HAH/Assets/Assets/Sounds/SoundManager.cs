using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D rb;
    public Vector3 PlayerPos;


    public AudioSource source;
    private float volLowRange = 0f;
    private float volHighRange = 1.0f;

    void Start() {
        PlayerPos = transform.position;
        source.Play();
    }

    void Update() {
        if
            (rb.velocity.x > 0 || rb.velocity.y > 0 || rb.velocity.x < 0 || rb.velocity.y < 0)
            {
            source.mute = false;
            }
        else
        {
            source.mute = true;
        }
    }
}

