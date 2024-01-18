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

        CameraLocationSeter.SetNewCameraTransformObject(gameObject);
        //TeleportPlayer(this.transform);
        
        
    }

    public override void LostControl()
    {
        //GetComponent<Renderer>().enabled = true;
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
