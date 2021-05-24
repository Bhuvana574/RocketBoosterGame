using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver: MonoBehaviour
{
    Text gameover;
    // Start is called before the first frame update
    void Start()
    {
        gameover = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FuelScript.fuelvalue == 0f )
        {
            gameover.text = "Game Over";

        }
    }
}