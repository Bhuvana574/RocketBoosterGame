using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ObstacleMovement : MonoBehaviour
{
    int speedAmt = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x <= 1.9)
        {
            speedAmt = 5;
        }
        if (transform.position.x >= 5.5)
        {
            speedAmt = -5;
        }
        transform.Translate(speedAmt * Time.deltaTime, 0, 0);//time.deltatime updates the timetaken

    }
    private void OnCollisionEnter(Collision collision)//for collisons
    {
        if(collision.gameObject.name=="Rocket")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(2);//to destroy gameobjects
        }
    }
}

