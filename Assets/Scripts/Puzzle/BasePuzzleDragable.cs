using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePuzzleDragable : MonoBehaviour
{
    [SerializeField] private BasePuzzleDragableModel model;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Drag(Vector2 dragpos)
    {
        

        if (model.IsHorizontal)
        {
            TryToMove(dragpos.x * model.DragMultiply);
        }
        else
        {
            TryToMove(-dragpos.y);
        }
    }

    private void TryToMove(float value)
    {
        
        if (IsEmptyControlWithRays(value))
        {
            Move(value);
        }
        
    }

    public virtual bool IsEmptyControlWithRays(float value)
    {
        foreach (Transform t in GetRayStarts(value))
        {
            RaycastHit hit;
            Debug.DrawRay(t.position, transform.right * value * 100, Color.red);
            if (Physics.Raycast(t.position, transform.right * value, out hit, Mathf.Abs(value)))
            {
                 return false;
            }
        }
        return true;
    }

    public void IsHorizontal(bool isHorizontal)
    {
        model.IsHorizontal = isHorizontal;
        if (!isHorizontal)
        {
            BecomeVertical();
        }
    }
    private void BecomeVertical()
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, -90); //Quaternion.LookRotation(Vector3.zero, new Vector3(0, 0, -90));
        transform.localPosition = transform.localPosition + transform.parent.right * 0.5f + transform.parent.up * 0.5f;

        Debug.Log("Turn");
    }
    private void Move(float value)
    {
        Vector3 pos = transform.position;
        pos += transform.right * value;
        transform.position = pos;
    }
    protected List<Transform> GetRayStarts(float value)
    {
        if (value > 0)
        {

            return model.RightRayLocations;
        }
      
        return model.LeftRayLocations;
    }
}
