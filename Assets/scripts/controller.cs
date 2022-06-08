using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public GameObject lazer;
    public float timer=3;
    public float Maxtimer;
    public bool IsActive;
    void Start()
    {
        Maxtimer = timer;
        IsActive = false;

    }

    void Update()
    {


        timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            lazer.SetActive(IsActive);
            IsActive = !IsActive;
            timer = Maxtimer;
        }


    }
}
