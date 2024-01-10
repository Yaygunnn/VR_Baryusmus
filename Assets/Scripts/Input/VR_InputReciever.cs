using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VR_InputReciever : MonoBehaviour
{
    [SerializeField] public InputActionReference ThumbStick2d;
    public Vector2 ThumbStick;
    [SerializeField] private InputActionReference RightTriggerButton;
    [SerializeField] private InputActionReference LeftTriggerButton;

    public Action RightTrigger;
    public Action RightTriggerCancell;

    public Action LeftTrigger;
    public Action LeftTriggerCancell;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(Trigger1d.action.ReadValue<float>());
    }


    

    private void SetThumbStick()
    {
        ThumbStick = ThumbStick2d.action.ReadValue<Vector2>();
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
