using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float ballForce;
    public Rigidbody rb;

    bool gameStarted = false;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false){

            transform.SetParent(null);


            rb.isKinematic = false;

            rb.AddForce(new Vector3(ballForce, 0, ballForce));

            gameStarted = true;
        }

        
    }

}
