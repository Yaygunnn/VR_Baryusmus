using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCreatorController : MonoBehaviour
{
    [SerializeField] private PuzzleCreatorModel model;
    void Start()
    {
        GameMod.Instance.PuzzleModStart += CreateNewPuzzle;
    }

    
    void Update()
    {
        
    }

    public void CreateNewPuzzle()
    {
        SelectRandomPuzzle();  // Test s�ras�nda bunu coment yap
        DestroyPreviousPuzzle();
        foreach(St_PuzzlePos block in model.PuzzlePosList)
        {
            GameObject piece;

            piece = CreatePuzzleBlock(block);

            model.PuzzlePieces.Add(piece);

            SetPuzzleBlockPosition(block, piece);
            
            SetHorizontal(block, piece.GetComponent<BasePuzzleDragable>());
        }
    }

    private void SelectRandomPuzzle()
    {
        int RandomSayi = Random.Range(0,model.puzzleCollection.puzzles.Count);
        model.PuzzlePosList = model.puzzleCollection.puzzles[RandomSayi].puzzleVersion;
    }
    private void DestroyPreviousPuzzle()
    {
        foreach(GameObject piece in model.PuzzlePieces)
        {
            Destroy(piece);
        }
        model.PuzzlePieces.Clear();
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
