using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{
    [EnumFlags]
    public GamePieceType Type;

    private void Start()
    {        
        GetSelectedGamePieceType();        
    }

    private void GetSelectedGamePieceType()
    {
        List<int> selectedTypes = new List<int>();
        for(int i = 0; i < System.Enum.GetValues(typeof(GamePieceType)).Length; i++)
        {
            int layer = 1 << i;
            if (((int)Type & layer) != 0)
            {
                selectedTypes.Add(i);
            }
        }

        if(selectedTypes.Count == 0 || selectedTypes.Count > 1)
        {
            throw new UnassignedReferenceException("You must select a single, valid Game Piece Type for each Game Piece object.");
        }

        this.Type = (GamePieceType)selectedTypes[0];
    }
}
