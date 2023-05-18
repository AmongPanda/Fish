using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildingRoad : MonoBehaviour
{
    [SerializeField]private TileBase buildTile;
    [SerializeField] private Tilemap tilemap;

    [SerializeField] private bool BuildingActive;

 
    public void Update() 
    {
        OnMouseDown();
        OnMouseOver();
    }
    // При нажатии на ПКМ стоиться дорожка
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)& BuildingActive)
        {
            Vector3Int cellPosition = tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            tilemap.SetTile(cellPosition, buildTile);
        }

    }
    // При нажатии на ЛКМ удаляеться дорожка
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1) & BuildingActive)
        {
            Vector3Int cellPosition = tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            tilemap.SetTile(cellPosition, null);
        }
    }
   public void ClickBuilding()
    {
        if(BuildingActive)
        {
            BuildingActive = false;
        }
        else if(!BuildingActive)
        {
            BuildingActive = true;
        }
    }
}