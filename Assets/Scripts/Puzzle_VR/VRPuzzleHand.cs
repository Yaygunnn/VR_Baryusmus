using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPuzzleHand : MonoBehaviour
{
    [SerializeField] VRPuzzleHandModel model;
    [SerializeField] GameObject anesne;
    

    private void Update()
    {
        if (model.Draging)
        {
            Drag();
        }
        else
        {
            //FoundObjectBehingHand();
        }
        //ShowHandAndSetPosition();
    }


    private Vector3 FoundVector()
    {

        return model.Hand.position - model.Head.position;
    }

    private bool FoundObjectBehingHand()
    {
        Ray ray = new Ray(model.Hand.position, FoundVector());
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit,100))
        {                        
            model.basePuzzleDragable = hit.collider.gameObject.GetComponentInParent<BasePuzzleDragable>();

            if (model.basePuzzleDragable != null)
            {
                StartDrag();
                HideHand();
                return true;
            }

            else
            {
               /* ray.GetPoint(hit.distance * 0.99f);
                a.transform.position = hit.point + hit.normal * 0.5f;*/

                TryToReachADragable((hit.point + hit.normal * 0.5f), hit.collider.transform);
                
                ShowHandAndSetPosition();
            }
        }
        else
        {
            ShowHandAndSetPosition();
        }
        return false;
    }

    private void ShowHand()
    {
        /*model.LocationShowHand.SetActive(true);*/
    }

    private void TryToReachADragable(Vector3 Origin, Transform transformm)
    {
        model.minPuzzleDistance=float.MaxValue;
        
                         
        TryToFindCloseDragable(new Ray(Origin, transformm.up));
        TryToFindCloseDragable(new Ray(Origin, transformm.up * (-1)));
        TryToFindCloseDragable(new Ray(Origin, transformm.right * (-1)));
        TryToFindCloseDragable(new Ray(Origin, transformm.right));

        if (model.basePuzzleDragable != null)
        {
            StartDrag();
            HideHand();
        }

    }

  
    private void TryToFindCloseDragable(Ray ray)
    {
       
        RaycastHit hitt;
        model.basePuzzleDragable = null;
        if (Physics.Raycast(ray, out hitt, model.MinNecesseryCloseDistance))
        {
            BasePuzzleDragable puzzlepiece = hitt.collider.GetComponent<BasePuzzleDragable>();

            if(puzzlepiece != null)
            {
                if(model.minPuzzleDistance>hitt.distance)
                {
                    model.minPuzzleDistance = hitt.distance;
                    
                    model.basePuzzleDragable = puzzlepiece;
                }               
            }
        }
            
    }

    private void ShowHandAndSetPosition()
    {
       /* ShowHand();
        model.LocationShowHand.transform.position = model.Hand.position + FoundVector() * model.Distance;*/
    }

    private void HideHand()
    {
        //model.LocationShowHand.SetActive(false);
    }
    private void StartDrag()
    {
        //Debug.Log("FoundPuzzle");
        model.PreviousHandPos=model.Hand.position;
        model.Draging = true;
    }

    public void TryStopDrag()
    {
        
        model.Draging=false;
    }
    private void Drag()
    {
        model.basePuzzleDragable.Drag(HandPosDif());
    }

    private Vector2 HandPosDif()
    {
        return new Vector2((model.Hand.position.x - model.PreviousHandPos.x) * model.DragSpeedX, (model.Hand.position.y - model.PreviousHandPos.y) * model.DragSpeedY);
    }

    
    public void SearchPuzzlePiece()
    {
        FoundObjectBehingHand();
    }
    

    
}
