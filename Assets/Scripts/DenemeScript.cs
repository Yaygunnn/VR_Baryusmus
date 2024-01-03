using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DenemeScript : MonoBehaviour
{

    [SerializeField] public InputActionReference move;

    [SerializeField] public InputActionReference PressedG;

    private void Update()
    {
        if (PressedG.action.inProgress)
        {
            WriteMoveInput();
        }
    }


    private void OnEnable()
    {
        PressedG.action.started += Pressg;
        PressedG.action.canceled += RemoveG;
        
        
    }

    private void WriteMoveInput()
    {
        Debug.Log(move.action.ReadValue<Vector2>());
    }
    private void OnDisable()
    {
        PressedG.action.started -= Pressg;
    }
    private void Pressg(InputAction.CallbackContext value)
    {
        Debug.Log("Pressed G");
    }
    private void ContinueG(InputAction.CallbackContext value)
    {
        Debug.Log("Continue G");
    }
    private void RemoveG(InputAction.CallbackContext value)
    {
        Debug.Log("Removed G");
    }
    /*private Cacik Sadinput = null;
    // Start is called before the first frame update
    void Start()
    {
        

        Sadinput = new Cacik();
    }

    private void OnEnable()
    {
        Sadinput.Enable();
        Sadinput.Player.Hit.performed += PressedG;
    }

    private void OnDisable()
    {
        Sadinput.Disable();
        Sadinput.Player.Hit.performed -= PressedG;
    }
    void Update()
    {
        
    }


    private void PressedG(InputAction.CallbackContext value)
    {
        Debug.Log("GPressed "+value);
    }*/


}
