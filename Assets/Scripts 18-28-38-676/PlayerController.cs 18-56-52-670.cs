using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement variables
    private float horizontalInput;
    private float verticalInput;
    private Vector2 inputVector;
    [SerializeField] private float speed = 10.0f;


    private void Update()
    {
        GetInputWithKeys();
        MovePlayer();
    }


    private void GetInputWithKeys()
    {
        Vector2 input = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            input.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            input.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            input.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input.x = +1;
        }
        inputVector = input.normalized;
    }

    private void MovePlayer()
    {
        Vector3 cameraForward = Camera.main.transform.forward; // Get the camera's forward vector

        // Flatten the camera forward vector so that it only affects the X and Z axes
        cameraForward.y = 0f;
        cameraForward.Normalize();

        Vector3 moveDirection = inputVector.x * transform.right + inputVector.y * cameraForward;

        transform.position += moveDirection * speed * Time.deltaTime;

        // Adjust the forward direction based on the camera's forward vector
        Vector3 newForward = Vector3.Slerp(transform.forward, cameraForward, Time.deltaTime * speed);
        transform.forward = new Vector3(newForward.x, 0f, newForward.z);
    }
}
