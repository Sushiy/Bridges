using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerController : MonoBehaviour
{
    public bool isInOnGround = false;
    public enum PlayerState
    {
        OnTree = 0,
        OnBranchH = 1,
        OnBranchV = 2,
        OnGround = 3
    }

    PlayerState currentState = PlayerState.OnTree;

    [Header("Movement")]
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    #region Input
    Vector2 moveInput;
    public void OnMove(CallbackContext c)
    {
        moveInput = c.ReadValue<Vector2>();
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(moveInput.x, 0.0f, moveInput.y);
        if(currentState == PlayerState.OnBranchH)
        {
            movement.z = 0;
        }
        else if(currentState == PlayerState.OnBranchV)
        {
            movement.x = 0;
        }

        transform.position += new Vector3(moveInput.x, 0.0f, moveInput.y) * (moveSpeed * Time.deltaTime);
    }
}
