using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class NewInputSystemsController : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 movement = Vector3.zero;
    private CharacterController characterController;

    public float jumpHeight = 3f;
    private float gravity = -9.81f;
    private float verticalVelocity;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        characterController.Move(movement);

        if (characterController.isGrounded == true && verticalVelocity < 0f)
        {
            verticalVelocity = 0f;
        }
        verticalVelocity -= gravity * Time.deltaTime;
        movement = movement * speed * Time.deltaTime;
        movement.y = verticalVelocity;
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("jumping!");
    }
    public void OnMove(InputAction.CallbackContext context)
    {
     
        Vector2 moveDirection = context.ReadValue<Vector2>();
        transform.position += new Vector3(moveDirection.x, 0f, moveDirection.y);
        movement = new Vector3(moveDirection.x, 0f, moveDirection.y);
    }
}
