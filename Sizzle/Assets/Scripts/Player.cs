using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed = 10f;

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

        transform.position = new Vector3(transform.position.x + inputVector.x * playerSpeed * Time.deltaTime, 0f, transform.position.z + inputVector.y * playerSpeed * Time.deltaTime);
        //transform.position += (Vector3)inputVector * playerSpeed * Time.deltaTime;
    }


}
