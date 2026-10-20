using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    // private PlayerControls controls;
    private CharacterController controller;
    private Vector3 velocity;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private bool shouldFaceMoveDirection = false;

    [Header("Speed Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float baseSpeed = 5f;
    [SerializeField] private float crouchSpeed = 3f;
    

    [Header("Jump Settings")]
    [SerializeField] private bool isGrounded;
    [SerializeField] private float gravity = -29.4f;
    [SerializeField] private float jumpHeight = 2f;
    

    [Header("Crouch Settings")]
    [SerializeField] private bool crouching = false;
    private float crouchTimer = 0;
    private bool lerpCrouch = false;
    private bool crouchByHold = false; // true when Ctrl initiated the current crouch

    [Header("Sprint Settings")]
    [SerializeField] private float sprintSpeed = 8f;
    [SerializeField] private bool sprinting = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        velocity = Vector3.zero;
        speed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;

        if(lerpCrouch)
        {
            crouchTimer += Time.deltaTime;
            float p = crouchTimer / .25f; // 0.25 seconds to complete the crouch/stand transition
            p *= p;
            if (crouching)
                controller.height = Mathf.Lerp(controller.height, 1, p);
            else
                controller.height = Mathf.Lerp(controller.height, 2 , p);

            if (p > 1)
            {
                lerpCrouch = false;
                crouchTimer = 0f;
            }
        }
    }

    public void OnMove(Vector2 input)
    {
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = forward * input.y + right * input.x;
        controller.Move(moveDirection * speed * Time.deltaTime);

        if(shouldFaceMoveDirection && moveDirection.sqrMagnitude > 0.001f)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, 10f * Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        controller.Move(velocity * Time.deltaTime);
    }

    public void OnJump()
    {
        Ray ray = new Ray(transform.position, Vector3.up);

        // if Ray hits a collider within the jumpHeight distance, it means there is a ceiling above the player
        // here, the jumpHeight is used as the max distance for the raycast
        // the controller.radius is used as the radius for the spherecast, to check if there is enough space for the player to jump
        if(Physics.SphereCast(ray, controller.radius, out RaycastHit hit, jumpHeight))
        {
            // if the ceilling is low but 
            if(hit.distance < jumpHeight)
            {
                
            } else
            {
                return;
            }
        }

        if(isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    public void OnSprint()
    {
        if(crouching) return;
        sprinting = !sprinting;
        speed = sprinting ? sprintSpeed : 5f;
        Debug.Log($"Sprinting : {sprinting}");


    }

    public void OnCrouchHold(bool isHeld)
    {
        // Debug.Log("START of OnCrouchHold");
        if (isHeld && !crouching)
        {
            Debug.Log($"Crouching : {isHeld}");
            crouchByHold = true;
            speed = crouchSpeed;
            SetCrouchState(true);
        } 
        else if (!isHeld && crouchByHold)
        {
            Debug.Log($"UnCrouching : {isHeld}");
            crouchByHold = false;
            speed = baseSpeed;
            SetCrouchState(false);            
        }
        // Debug.Log("END of OnCrouchHold");
    }

     private void SetCrouchState(bool shouldCrouch)
    {
        if (shouldCrouch == crouching)
            return;

        // Verify there is enough space above the player before standing.
        if (!shouldCrouch)
        {
            Debug.Log("Checking space above player before standing");
            Ray ray = new Ray(transform.position, Vector3.up);
            if (Physics.SphereCast(ray, controller.radius, out RaycastHit hit, 1f))
            {
                Debug.Log($"Hit something above player. Distance : {hit.distance}, Collider : {hit.collider.name}");
                if (hit.distance < 1f)
                    return;
            }
        }

        crouching = shouldCrouch;
        crouchTimer = 0;
        lerpCrouch = true;
        // if (crouching)
        // {
        //     // Sprint while crouched only allowed if crouch was triggered by C (not Ctrl).
        //     if (sprinting && !crouchByHold)
        //         speed = crouchSprintSpeed;
        //     else
        //     {
        //         sprinting = false;
        //         speed = crouchSpeed;
        //     }
        // }
        // else
        //     speed = sprinting ? sprintSpeed : 5f;
    }

}
