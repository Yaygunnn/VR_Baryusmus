using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseElectronicController : MonoBehaviour
{
    
    public void Start()
    {
        ElectronicManagerController.Instance.AddToTheAllElectronicList(this);
        
    }
    public virtual void TakenControl()  // called when player hacked and take control of this electronic
    {

    }

    public virtual void LostControl()   // called when player hacked and take control of another electronic 
    {

    }

    public virtual void LeftAnalog2D(Vector2 axis)
    {

    }
    public virtual void MouseMovementX(float mouseX)
    {

    }

    public virtual void MouseMovementY(float mouseY)
    {

    }

    protected virtual void TeleportPlayer(Transform ttransform)
    {
        if (GameModel.Instance.Player == null)
        {
            Debug.Log("Oyuncun yok");
        }
        GameModel.Instance.Player.transform.position = ttransform.position;
        GameModel.Instance.Player.transform.rotation = ttransform.rotation;
    }

}
