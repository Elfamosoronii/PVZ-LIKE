using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.InputSystem;

public class BuildingPlacement : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private TileMap_Manager _tileMapManager;
    public void GetMousePosition(InputAction.CallbackContext _context)

    {
      
        Vector3 _mousePositionWorld = _camera.ScreenToWorldPoint(_context.ReadValue<Vector2>());
        Debug.Log(_mousePositionWorld);
       _tileMapManager.GetTileData(_mousePositionWorld);
    }

}
