using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class BuildingPlacement : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private TileMap_Manager _tileMapManager;
    [SerializeField] private Building building;
    private Vector2 _mousePositionWorld;
    private Building previewBuilding;
    private TilemapData tiledata = null;
     public void GetMousePosition(InputAction.CallbackContext _context)

    {
      
        _mousePositionWorld = _camera.ScreenToWorldPoint(_context.ReadValue<Vector2>());
        Debug.Log(_mousePositionWorld);
        if (previewBuilding != null)
        {
            previewBuilding.transform.position = (Vector3Int)_tileMapManager.GetTilePosition(_mousePositionWorld);
        }
       tiledata = _tileMapManager.GetTileData(_mousePositionWorld);
        
    }

    public void ValidateBuilding(InputAction.CallbackContext _context)
    { 
        if (_context.performed)
        {
            if (tiledata != null && tiledata.IsValid)
            {
                previewBuilding = null;
            }
        }
    }
    public void Start()
    {
        InstantiatePreview(building);
    }
    private void InstantiatePreview(Building _building)
    {
       previewBuilding = Instantiate(_building, _mousePositionWorld, Quaternion.identity);
    }

}
