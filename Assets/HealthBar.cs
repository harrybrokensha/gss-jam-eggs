using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealthBar : MonoBehaviour
{
    public Image ImgHealthBar;

   

    public float MaxTime;
    public float Counter;
    public Text CounterText;
    public ShadowDetectorChecker MyShadowChecker;
    public GameObject myObject;
    private bool isCreated;
    private float FinalValue;


    void Start()
    {
        isCreated = false;
    }

    void Update()
    {
        if (MyShadowChecker.ItBurns)
        {
            Counter += Time.deltaTime;

            if (Counter >= MaxTime )//&& !isCreated)
            {
                Instantiate(myObject, MyShadowChecker.transform.position, MyShadowChecker.transform.rotation);
                //Counter = MaxTime / 2f;
                //isCreated = true;
                Counter = 0f;
            }


        }
        else
        {
            isCreated = false;
            Counter -= 0.5f * Time.deltaTime;
            if (Counter <= 0f)
            {
                Counter = 0f;
            }
        }
        FinalValue = 1.0f - (Counter / MaxTime);
        ImgHealthBar.fillAmount = FinalValue;
        CounterText.text = FinalValue.ToString("0.00");
    }


    
}
