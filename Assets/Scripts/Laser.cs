using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    private float timeTilSpawn;

    public ParticleSystem dust;

    public float startTimeTilSpawn;

    public GameObject lazer;
    public Transform whereToSpawn;

    private void Update()
    {
        void CreateDust()
        {
            dust.Play();
        }
        if (timeTilSpawn <= 0)
        {
            Instantiate(lazer, whereToSpawn.position, whereToSpawn.rotation);
            timeTilSpawn = startTimeTilSpawn;
            CreateDust();
            SoundManagerScript.PlaySound("laser");
        }
        else
        {
            timeTilSpawn -= Time.deltaTime;
        }
    }
    
}