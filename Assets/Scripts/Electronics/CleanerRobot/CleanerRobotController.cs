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
        //EskiMovement();
        SetRotation();
    }

    private void SetRotation()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, GetDesiredTransform(), model.RotationLerpValue * Time.deltaTime);
    }
    private Quaternion GetDesiredTransform()
    {
        Vector3 CamForward = GameModel.Instance.camera.transform.forward;
        Vector3 CamRight = GameModel.Instance.camera.transform.right;
        CamForward.y = 0;
        CamForward = CamForward.normalized;
        Vector3 newup = Vector3.Cross(CamForward, CamRight);
        Quaternion returnvalue = Quaternion.LookRotation(CamForward, newup);
        return returnvalue;
    }
    private void EskiMovement()
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
        CameraLocationSeter.SetNewCameraTransformObject(model.CameraLocation.gameObject);
        //CameratransformManagement();
    }

    private void CameratransformManagement()
    {
        TeleportPlayer(model.CameraLocation);
        GameModel.Instance.Player.transform.SetParent(model.CameraLocation, true);
    }

    public override void LostControl()
    {
        base.LostControl();
        model.NewMoveInput = new Vector2(0, 0);
        model.CurrentMove = new Vector2(0, 0);

    }
}
