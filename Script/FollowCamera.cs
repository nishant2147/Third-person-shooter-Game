using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class FollowCamera : MonoBehaviour
{
    Transform Player;
    Vector3 offset;
    public Transform pivot;

    //public float smoothSpeed = 0.125f;
    public float rotationSpeed = 5.0f;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - Player.position;
    }
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;

        var mouseX = CrossPlatformInputManager.GetAxis("Mouse X");
        var mouseY = CrossPlatformInputManager.GetAxis("Mouse Y");
        pivot.Rotate(mouseY, mouseX, 0);
        var newRotation = Quaternion.Euler(pivot.eulerAngles.x, pivot.eulerAngles.y, 0);

        var newPos = Player.position + (newRotation * offset);
        transform.position = newPos;

        transform.LookAt(pivot);

        /*float horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed;
        offset = Quaternion.AngleAxis(horizontalInput, Vector3.up) * offset;

        Vector3 currentPosition = Player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, currentPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(Player);*/
    }
}
