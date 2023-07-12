using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public float speed = 15f;
    public Rigidbody rb;

    public float maxX;

    void Update()
    {
        float inputSpeed = 0f;

        inputSpeed = Input.GetAxisRaw("PlayerMovement");

        transform.position += new Vector3(inputSpeed * speed * Time.deltaTime, 0f, 0f );

        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;

    }


}
