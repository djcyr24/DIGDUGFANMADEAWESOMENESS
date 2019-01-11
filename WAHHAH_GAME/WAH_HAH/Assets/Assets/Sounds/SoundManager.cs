using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    [SerializeField]
    private WaluigiController20002 player;

    public AudioSource source;
    private float volLowRange = 0f;
    private float volHighRange = 1.0f;

    void Update() {
        if (player.IsWalking || player.IsDiggingSE)
        {
            source.UnPause();
        } else
        {
            source.Pause();
        }
    }
}

