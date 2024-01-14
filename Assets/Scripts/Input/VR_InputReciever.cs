using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VR_InputReciever : MonoBehaviour
{
    [SerializeField] public InputActionReference ThumbStickLeft2d;
    public Vector2 ThumbStick;
    [SerializeField] private InputActionReference RightTriggerButton;
    [SerializeField] private InputActionReference LeftTriggerButton;

    public Action RightTrigger;
    public Action RightTriggerCancell;

    public Action <Vector2> LeftAnalog2d;

    public Action LeftTrigger;
    public Action LeftTriggerCancell;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FLeftAnalog();

        //Debug.Log(Trigger1d.action.ReadValue<float>());
        //Debug.Log(ThumbStickLeft2d.action.ReadValue<Vector2>());
    }


    

    private void SetThumbStick()
    {
        ThumbStick = ThumbStickLeft2d.action.ReadValue<Vector2>();
    }

    private void FLeftAnalog()
    {
        if(LeftAnalog2d != null)
        {
            LeftAnalog2d(ThumbStickLeft2d.action.ReadValue<Vector2>());
            
        }
    }


    private void FRightTrigger(InputAction.CallbackContext value)
    {
        if(RightTrigger != null)
        {
        
            RightTrigger();
        }
    }

    private void FRightTriggerCancell(InputAction.CallbackContext value)
    {
        if(RightTriggerCancell != null)
        {
            RightTriggerCancell();
        }
    }

    private void FLeftTrigger(InputAction.CallbackContext value)
    {
        if (LeftTrigger != null)
        {

            LeftTrigger();
        }
    }

    private void FLeftTriggerCancell(InputAction.CallbackContext value)
    {
        if (LeftTriggerCancell != null)
        {
            LeftTriggerCancell();
        }
    }

    private void OnEnable()
    {
        RightTriggerButton.action.started += FRightTrigger;
        RightTriggerButton.action.canceled += FRightTriggerCancell;
        LeftTriggerButton.action.started += FLeftTrigger;
        LeftTriggerButton.action.canceled += FLeftTriggerCancell;
    }

    private void OnDisable()
    {
        RightTriggerButton.action.started -= FRightTrigger;
        RightTriggerButton.action .canceled -= FRightTriggerCancell;
        LeftTriggerButton.action.started -= FLeftTrigger;
        LeftTriggerButton.action.canceled -= FLeftTriggerCancell;
    }
}
