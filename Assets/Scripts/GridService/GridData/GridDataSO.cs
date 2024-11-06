using UnityEngine;

[CreateAssetMenu(fileName ="GridData",menuName ="Data/newGridData")]
public class GridDataSO:ScriptableObject
{
    public int column;
    public int rows;
    public float squareScaleX;
    public float squareScaleY;
    public Vector2 StartPosition;
    public float everySquareOffset;
    public GameObject GridSquarePrefab;
}

