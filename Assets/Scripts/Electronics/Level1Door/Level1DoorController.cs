using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1DoorController : BaseElectronicController
{
    [SerializeField] Level1DoorModel model; 
    void Start()
    {
        base.Start();
    }

    
    public override void TakenControl()
    {
        base.TakenControl();
        TeleportPlayer(model.level2DoorCameraTeleportLocation);

        FireLevel2StartedAction();
    }

    private void FireLevel2StartedAction()
    {
        if (model.Level2StartedAction != null)
        {
            model.Level2StartedAction();
        }
    }
}
