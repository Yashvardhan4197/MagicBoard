
public class GridService
{
    private GridSpawnerController gridSpawner;

    public GridService(GridDataSO gridDataSO,GridSpawnerView gridSpawnerView)
    {
        gridSpawner=new GridSpawnerController(gridDataSO,gridSpawnerView);
    }
}
