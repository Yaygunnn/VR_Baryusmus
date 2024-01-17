using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCreatorModel :MonoBehaviour
{
    public Vector3 FirstCellPosition { get; } = new Vector3(-3, 2.5f, 0);
    public float DistanceBetweenCells { get; } = 1f;

    public List<GameObject> PuzzlePieces;

    [SerializeField] public GameObject PuzzlePiece1;

    [SerializeField] public GameObject PuzzlePiece2;

    [SerializeField] public GameObject PuzzlePiece3;

    [SerializeField] public GameObject PuzzleKey;

    [HideInInspector] public List<St_PuzzlePos> PuzzlePosList;

    [SerializeField] public  PuzzleCollection puzzleCollection;

    
}
