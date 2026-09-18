using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 moveInput;

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        if (moveInput.x > 0)
        {
            visual.localScale = new Vector3(1, 1, 1);
        }
        else if (moveInput.x < 0)
        {
            visual.localScale = new Vector3(-1, 1, 1);
        }
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("점프!");
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);

        }
    }

    void Update()
    {
        transform.Translate(Vector3.right * moveInput.x * moveSpeed * Time.deltaTime);
    }
}

