using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GameService : GenericMonoSingleton<GameService>
{
    private GridService gridService;
    public GridService GridService { get { return gridService; } }

    #region VIEWS
    [SerializeField] GridSpawnerView gridSpawnerView;
    #endregion

    #region DATA
    [SerializeField] GridDataSO GridDataSO;
    #endregion

    #region ACTIONS
    public UnityAction StartGame;
    public UnityAction ENDGame;
    #endregion

    private void Start()
    {
        gridService = new GridService(GridDataSO,gridSpawnerView);
    }
}
