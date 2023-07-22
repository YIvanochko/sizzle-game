using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationSpeed = 10f;
    [SerializeField] GameInput gameInput;

    Transform playerPosition;

    bool isWalking = false;

    private void Start()
    {

    }

    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDirection = new Vector3(inputVector.x, 0f, inputVector.y);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        isWalking = moveDirection != Vector3.zero;

        if (isWalking) { transform.forward = Vector3.Slerp(transform.forward, moveDirection, rotationSpeed * Time.deltaTime); }
    }

    public bool IsWalking() => isWalking;


}
