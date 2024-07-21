using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controll;
    [SerializeField] float playerSpeed;
    public Transform pivot;
    Animator animator;
    /*public float turntime = 0.1f;
    float turnVelocity;*/

    // Start is called before the first frame update
    void Start()
    {
        controll = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Playermoving();

        float horiAxis = Input.GetAxis("Horizontal");
        float verAxis = Input.GetAxis("Vertical");

        var Movement = horiAxis * transform.right + verAxis * transform.forward;
        Movement *= playerSpeed;
        /*if(controll.isGrounded)
        {
            animator.SetBool("Jump", false);

            if(Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("Jump", true);
            }
        }*/

        controll.Move(Movement * Time.deltaTime);

        pivot.position = transform.position;

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Run", false);
            transform.rotation = Quaternion.Euler(0, pivot.eulerAngles.y, 0);
        }
        else
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Run", false);
        }

        RunningPlayer();
    }
    private void RunningPlayer()
    {
        bool isRunning = Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift);

        if (isRunning)
        {
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Run", false);
        }
    }

    /*private void Playermoving()
    {
        float horiAxis = Input.GetAxis("Horizontal");
        float verAxis = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horiAxis, 0f, verAxis).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float playerangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, playerangle, ref turnVelocity, turntime);
            transform.rotation = Quaternion.Euler(0, angle, 0);

            controll.Move(direction.normalized * playerSpeed * Time.deltaTime);
        }
    }*/
}
