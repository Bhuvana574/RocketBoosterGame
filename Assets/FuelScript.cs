using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//ui is used to add text,canvas,events
public class FuelScript : MonoBehaviour
{
    public static float fuelvalue = 999f;
    Text Fuel;
    // Start is called before the first frame update
    void Start()
    {
        Fuel = GetComponent<Text>();//to get component text
        
    }

    // Update is called once per frame
    void Update()
    {
        Fuel.text = "FUEL : " + fuelvalue;
    }
}