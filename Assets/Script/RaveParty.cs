using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using Random = UnityEngine.Random;

public class RaveParty : MonoBehaviour
{
    public float BaseTimer = 5.0f;
    private float Timer;
    public Light PurpLight;
    [SerializeField] private static ParticleSystem Flames1Particules;
    [SerializeField] private static ParticleSystem Flames2Particules;
    [SerializeField] private static ParticleSystem Flames3Particules;
    [SerializeField] private static ParticleSystem Flames4Particules;
    //private ParticleSystem.MainModule F1PM = Flames1Particules.main;
    //private ParticleSystem.MainModule F2PM = Flames2Particules.main;
    //private ParticleSystem.MainModule F3PM = Flames3Particules.main;
    //private ParticleSystem.MainModule F4PM = Flames4Particules.main;
    private bool RaveTime = false;

    // Start is called before the first frame update
    void Start() 
    {
        Timer = BaseTimer;
    }

    // Update is called once per frame
    void Update()
    {
        while (Timer >= 0.0f && RaveTime)
        {
            Timer -= Time.deltaTime;
        }

        Rave();
        Timer = BaseTimer;
    }

    void Rave()
    {
        Color RaveColor = RngColor();
        PurpLight.color = RaveColor;
        //F1PM.startColor = RaveColor;
        //F2PM.startColor = RaveColor;
        //F3PM.startColor = RaveColor;
    }

    Color RngColor()
    {
        float red = Random.value;
        float green = Random.value;
        float blue = Random.value;

        return new Color(red, green, blue, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        RaveTime = true;
    }
    
    private void OnTriggerExit(Collider other)
    {
        RaveTime = false;
    }
}
