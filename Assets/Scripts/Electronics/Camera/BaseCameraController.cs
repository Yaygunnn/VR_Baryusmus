using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCameraController : BaseElectronicController
{
    private void Start()
    {
        base.Start();
        
        
    }
    private void Update()
    {
    }
    public override void TakenControl()
    {
        GetComponent<Renderer>().enabled = false;

        TeleportPlayer(this.transform);
        
        //SetCameraTransform();
    }

    public override void LostControl()
    {
        GetComponent<Renderer>().enabled = true;
    }

    private void SetCameraTransform()// keyboard mouse
    {
        Camera camera = Camera.main;
        camera.transform.position = this.transform.position;
        camera.transform.rotation = this.transform.rotation;
    }

    
    public override void MouseMovementX(float mouseX)
    {
 

       // Camera.main.transform.Rotate(0, mouseX, 0);
    }

    public override void MouseMovementY(float mouseY)
    {
     

        //Camera.main.transform.Rotate(-mouseY, 0, 0);
    }


    
}
