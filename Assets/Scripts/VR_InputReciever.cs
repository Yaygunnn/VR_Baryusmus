using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VR_InputReciever : MonoBehaviour
{
    [SerializeField] public InputActionReference ThumbStick2d;
    public Vector2 ThumbStick;
    [SerializeField] public InputActionReference Trigger1d;

    public Action RightTrigger;
    public Action RightTriggerCancell;
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

    private void OnEnable()
    {
        Trigger1d.action.started += FRightTrigger;
        Trigger1d.action.canceled += FRightTriggerCancell;
    }

    private void OnDisable()
    {
        Trigger1d.action.started -= FRightTrigger;
        Trigger1d.action .canceled -= FRightTriggerCancell;
    }
}
