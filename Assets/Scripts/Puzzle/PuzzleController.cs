using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    private BasePuzzleDragable basePuzzleDragable;
    private bool Draging;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TryDrag(Vector2 dragpos)
    {
        if (Draging) 
        { 
            basePuzzleDragable.Drag(dragpos);
        }

    }
    
    public void TryToHoldAPuzzlePiece()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit))
        {
            basePuzzleDragable = hit.collider.gameObject.GetComponentInParent<BasePuzzleDragable>();

            if (basePuzzleDragable != null)
            {
                StartDrag();
            }
        }
    }

    private void StartDrag()
    {        
        Draging = true;
    }
    
    private void StopDrag()
    {
        Draging = false;
    }
    public void TryToStopDrag()
    {
        if (Draging)
        {
            StopDrag();
        }
    }
}
