using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="puzzlecollection", menuName = "puzzlemenu")]
public class PuzzleCollection : ScriptableObject
{
    [SerializeField] public List<PuzzleVersion> puzzles;
}
