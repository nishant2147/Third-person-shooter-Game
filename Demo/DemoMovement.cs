using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoMovement : MonoBehaviour
{

    CharacterController Controller;
    float playerSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiAxis = Input.GetAxis("Horizontal");
        float verAxis = Input.GetAxis("Vertical");

        var Movement = horiAxis * transform.right + verAxis * transform.forward;
        Movement *= playerSpeed * Time.deltaTime;

        if (Controller.isGrounded)
        {
            //jump = false
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //jump = true
                Movement.y = 10;
            }

            print("====>  " + Physics.gravity.y);
        }

        Movement.y += Physics.gravity.y * Time.deltaTime;

        Controller.Move(Movement );

    }
}
