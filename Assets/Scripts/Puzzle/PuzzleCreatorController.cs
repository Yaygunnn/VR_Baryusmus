using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCreatorController : MonoBehaviour
{
    [SerializeField] private PuzzleCreatorModel model;
    void Start()
    {
        CreatePuzzle();
    }

    
    void Update()
    {
        
    }

    void CreatePuzzle()
    {
        foreach(St_PuzzlePos block in model.PuzzlePosList)
        {
            GameObject piece;

            piece = CreatePuzzleBlock(block);

            SetPuzzleBlockPosition(block, piece);
            
            SetHorizontal(block, piece.GetComponent<BasePuzzleDragable>());
        }
    }

    private void SetHorizontal(St_PuzzlePos block, BasePuzzleDragable basePuzzleDragable)
    {
        basePuzzleDragable.IsHorizontal(block.IsHorizontal);
    }
    private GameObject CreatePuzzleBlock(St_PuzzlePos block)
    {
        switch (block.PieceType)
        {
            case E_PuzzlePiece.OnePiece:
                return Instantiate(model.PuzzlePiece1, this.transform);
                
            case E_PuzzlePiece.DoublePiece:
                return Instantiate(model.PuzzlePiece2, this.transform);
                
            case E_PuzzlePiece.TriplePiece:
                return Instantiate(model.PuzzlePiece3, this.transform);
                
            case E_PuzzlePiece.Key:
                return Instantiate(model.PuzzleKey, this.transform);
                
            default: break;
        }
        return null;
    }
    private void SetPuzzleBlockPosition(St_PuzzlePos blockinfo, GameObject obje)
    {
        Vector3 pos = new Vector3();
        pos = model.FirstCellPosition;
        pos += new Vector3(blockinfo.x, -blockinfo.y, 0) * model.DistanceBetweenCells;

        obje.transform.localPosition = pos;
    }
}
