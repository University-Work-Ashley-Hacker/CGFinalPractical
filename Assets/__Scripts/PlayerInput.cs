using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public static Action<Vector2> MoveEvent;
    public static Action<Vector2> LookEvent;
    public static Action ShootEvent;

    public void OnMove(InputAction.CallbackContext context)
    {
        MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }
    
    public void OnLook(InputAction.CallbackContext context)
    {
        LookEvent?.Invoke(context.ReadValue<Vector2>());
    }
    
    public void OnShoot(InputAction.CallbackContext context)
    {
        if (!context.performed) return;

        ShootEvent?.Invoke();
        
    }

}
