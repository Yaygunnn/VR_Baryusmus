using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPuzzleCollectionTest : MonoBehaviour
{
    [SerializeField] PuzzleCollection puzzleCollection;
    [SerializeField] PuzzleCreatorController controller;
    [SerializeField] PuzzleCreatorModel model;
    [SerializeField] int index;
    void Start()
    {
        model.PuzzlePosList = puzzleCollection.puzzles[index].puzzleVersion;
        controller.CreateNewPuzzle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
