using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePuzzleDragableModel : MonoBehaviour
{
    public bool IsHorizontal;

    public float DragMultiply { get; } = 0.2f;

    public List<Transform> RightRayLocations;
    public List<Transform> LeftRayLocations;
   
}
