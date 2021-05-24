
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool thrust = false;//to give mass to rocket

    public float fuel = 999f;//fuel value range

    public float rocketspeed;
    
    Rigidbody rb;
    public static bool gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        thrust = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (thrust)
        {
            if (fuel > 0)
            {
                rb.AddRelativeForce(Vector3.up * rocketspeed * Time.deltaTime);
                fuel -= 1;
                FuelScript.fuelvalue -= 1;
                print(fuel);
            }
           
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * rocketspeed);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * rocketspeed);
            
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * rocketspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.back * rocketspeed * Time.deltaTime);
        }

        booster();
    }


    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        //if (collision.gameObject.tag == "Ground")
        //{
        //  booster();
        //}
        if (collision.gameObject.tag == "Ground")
        {
            //Destroy(gameObject, 0);
            //Debug.Log("GAME OVER");
        }


    }
    private void booster()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
           
            transform.Translate(Vector3.up * rocketspeed * Time.deltaTime);
            //Move the Rigidbody upwards constantly at speed axis in Scene view
            
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -rocketspeed, 0) * Time.deltaTime);  //Move the Rigidbody downwards
            
        }

      
    }


}






