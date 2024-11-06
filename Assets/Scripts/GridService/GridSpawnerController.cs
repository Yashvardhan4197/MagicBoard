using System.Collections.Generic;
using UnityEngine;

public class GridSpawnerController
{
    private GridDataSO GridDataSO;
    private GridSpawnerView gridspawnerView;

    private List<GameObject> GridSquareList;
    public GridSpawnerController(GridDataSO gridDataSO,GridSpawnerView gridSpawnerView)
    {
        GridDataSO= gridDataSO;
        this.gridspawnerView= gridSpawnerView;
        gridSpawnerView.SetController(this);
        GridSquareList = new List<GameObject>();
        GameService.Instance.StartGame += CreateGrid;
        GameService.Instance.StartGame += PositionGrid;
        CreateGrid();
        PositionGrid();
    }

    public void CreateGrid()
    {
        for(int i=0;i<GridDataSO.rows*GridDataSO.column;i++)
        {
            GridSquareList.Add(Object.Instantiate(GridDataSO.GridSquarePrefab));
            GridSquareList[GridSquareList.Count - 1].transform.SetParent(gridspawnerView.gameObject.transform);
            GridSquareList[GridSquareList.Count - 1].transform.localScale = new Vector2(GridDataSO.squareScaleX, GridDataSO.squareScaleY);
            GridSquareList[GridSquareList.Count - 1].GetComponent<GridSquareView>().ToggleGridSquareImage((GridSquareList.Count - 1) % 2);
        }
    }
    public void PositionGrid()
    {
        int r = 0;
        int i = 0;
        int c = 0;
        var offsetX = (GridDataSO.GridSquarePrefab.GetComponent<RectTransform>().rect.width * GridDataSO.squareScaleX) + GridDataSO.everySquareOffset;
        var offsetY = (GridDataSO.GridSquarePrefab.GetComponent<RectTransform>().rect.height * GridDataSO.squareScaleY) + GridDataSO.everySquareOffset;
        while (r<GridDataSO.rows&&i<GridSquareList.Count)
        {
            if(c>=GridDataSO.column)
            {
                c = 0;
                r++;
            }
            var posOffsetX = offsetX * c;
            var posOffsetY = offsetY * r;
            //GridSquareList[i].GetComponent<RectTransform>().anchoredPosition =new Vector3 (GridDataSO.StartPosition.x+posOffsetX,GridDataSO.StartPosition.y-posOffsetY);
            GridSquareList[i].GetComponent<RectTransform>().localPosition = new Vector3(GridDataSO.StartPosition.x + posOffsetX, GridDataSO.StartPosition.y - posOffsetY);
            c++;
            i++;
        }
    }
}