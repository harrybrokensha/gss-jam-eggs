using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed;
    public float Xvalue;
    public float Yvalue;
    public float Zvalue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Xvalue, Yvalue, Zvalue * Time.deltaTime + RotationSpeed); //rotates 50 degrees per second around z axis
    }
}
