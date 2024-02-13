using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleKeyDragable : BasePuzzleDragable
{
    bool Achieved;
    public override bool IsEmptyControlWithRays(float value)
    {
        if (!Achieved)
        {
            ControlSuccess(value);
        }
        

        return base.IsEmptyControlWithRays(value);
    }

    private void Success()
    {
        Debug.Log("Gönderdim");
        //GetComponentInParent<IPuzzleSuccess>().PuzzleSuccess();
        Achieved = true;
        PuzzleSuccessor.Instance.PuzzleSolved();
    }
    private void ControlSuccess(float value)
    {
        foreach (Transform t in GetRayStarts(value))
        {
            RaycastHit hit;

            if (Physics.Raycast(t.position, transform.right * value, out hit, Mathf.Abs(value)))
            {

                if (hit.collider.CompareTag("PuzzleLock"))
                {
                    Success();
                }
                
            }
        }
    }
}
