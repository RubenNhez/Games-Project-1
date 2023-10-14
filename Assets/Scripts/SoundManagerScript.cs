using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerDeathSound, canonSound, laserSound, coinSound, keySound;
    static AudioSource audioScr;
    // Start is called before the first frame update
    void Start()
    {
        playerDeathSound = Resources.Load<AudioClip>("playerDeath");
        canonSound = Resources.Load<AudioClip>("canon");
        laserSound = Resources.Load<AudioClip>("laser");
        coinSound = Resources.Load<AudioClip>("coin");
        keySound = Resources.Load<AudioClip>("key");

        audioScr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "canon":
                audioScr.PlayOneShot(canonSound);
                break;
            case "playerDeath":
                audioScr.PlayOneShot(playerDeathSound);
                break;
            case "laser":
                audioScr.PlayOneShot(laserSound);
                break;
            case "coin":
                audioScr.PlayOneShot(coinSound);
                break;
            case "key":
                audioScr.PlayOneShot(keySound);
                break;

        }
    }
}
