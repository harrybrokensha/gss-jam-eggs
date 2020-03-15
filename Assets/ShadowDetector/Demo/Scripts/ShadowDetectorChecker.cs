using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ShadowDetectorChecker : MonoBehaviour {

    public Text sensorBr;
    public Transform eyeEnabled;
    public Transform eyeDisabled;
    private ShadowDetector sd;
    private Image img;
    public bool ItBurns;
   
   


    void Start () {
        sd = transform.GetComponent<ShadowDetector>();
        img = eyeEnabled.GetComponent<Image>();
      
    }
	
	void Update () {

        

        if (sd.hidden)
        {
            eyeEnabled.gameObject.SetActive(false);
            eyeDisabled.gameObject.SetActive(true);

            ItBurns = false;
        }
        else
        {
            eyeEnabled.gameObject.SetActive(true);
            eyeDisabled.gameObject.SetActive(false);
           
            // Do smth when exposed to sunlight
            ItBurns = true;

        }
        img.color = new Color(img.color.r, img.color.g, img.color.b, sd.bright / sd.maxShadowBright);
        sensorBr.text = "Sensor Bright: " + System.Math.Round(sd.bright, 2);

        if (ItBurns)
        {
           
            
        }

        
    }

}
