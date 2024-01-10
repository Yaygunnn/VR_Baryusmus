using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanerRobotController : BaseElectronicController
{
    [SerializeField] CleanerRobotModel model;

    
   
    private void Start()
    {
        base.Start();
    }

    
    void Update()
    {
        Movement();
    }


    private void Movement()
    {
        Vector2 speed = Time.deltaTime * model.MaxSpeed * Vector2.SmoothDamp(model.CurrentMove, model.NewMoveInput, ref model.CurrentMove, model.SmoothTime, 10);

        Transform tt=GameModel.Instance.camera.transform;


        Vector3 forward = tt.forward;
        forward.y = 0;

        Vector3 right = tt.right;
        right.y = 0;

        Vector3 pos = forward * speed.y + right * speed.x;
        
        model.characterController.Move(pos);
        

    }
    public override void LeftAnalog2D(Vector2 axis) 
    {
        Debug.Log(axis);
        model.NewMoveInput = axis;
    }

    public override void TakenControl()
    {
        base.TakenControl();
        CameratransformManagement();
    }

    private void CameratransformManagement()
    {
        TeleportPlayer(model.CameraLocation);
        GameModel.Instance.Player.transform.SetParent(model.CameraLocation, false);
    }

    public override void LostControl()
    {
        base.LostControl();
        model.NewMoveInput = new Vector2(0, 0);
        model.CurrentMove = new Vector2(0, 0);

    }
}
