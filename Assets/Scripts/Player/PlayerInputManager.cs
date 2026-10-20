using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    public PlayerControls controls;
    public PlayerControls.GameplayActions gameplayControls;
    public PlayerControls.CameraControlsActions cameraControls;


    private PlayerMovements motor;


    void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();
        gameplayControls = controls.Gameplay;
        cameraControls = controls.CameraControls;

        motor = GetComponent<PlayerMovements>();
        
        gameplayControls.Sprint.performed += ctx => motor.OnSprint();
    }

    void FixedUpdate()
    {
        motor.OnMove(gameplayControls.Move.ReadValue<Vector2>());

        if (gameplayControls.Jump.IsPressed())
        {
            Debug.Log("Jump button pressed");
            motor.OnJump();
        }

        bool ctrlHeld = (Keyboard.current != null && Keyboard.current.leftCtrlKey.isPressed) || (Gamepad.current != null && Gamepad.current.buttonEast.isPressed);
        // Debug.Log($"Is Ctrl Held : {ctrlHeld}");
        motor.OnCrouchHold(ctrlHeld);
    }
}
