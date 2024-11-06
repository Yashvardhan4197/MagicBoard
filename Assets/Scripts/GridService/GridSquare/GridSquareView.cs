
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSquareView : MonoBehaviour
{
    public Image currentImage;
    [SerializeField] List<Sprite> Images;

    public void ToggleGridSquareImage(int i)
    {
        currentImage.sprite = Images[i];
    }
}
