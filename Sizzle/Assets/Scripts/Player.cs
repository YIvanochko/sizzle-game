using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationSpeed = 10f;

    Transform playerPosition;

    private void Start()
    {

    }
    private void Update()
    {

        Vector2 inputVector = new Vector2(0.0f, 0.0f);
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = 1f;
        }

        inputVector = inputVector.normalized;

        Vector3 moveDirection = new Vector3(inputVector.x, 0f, inputVector.y);

        transform.forward = Vector3.Slerp(transform.forward, moveDirection, rotationSpeed * Time.deltaTime);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }


}
