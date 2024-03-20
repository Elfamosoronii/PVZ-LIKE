using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 [System.Serializable]
public class TilemapData
{
    public bool hover = false;  
    public bool IsValid
    {
        get
        {
            return hasTile && building is null;
        }

    }
   private Building building = null; 
   

    public Building Building 
    { 
        get { return building; } 
        set {
            if (building != value)
                building = value;
            } 
    } 

    private int layerIndex = -1;
    private bool hasTile = false;

   
    public TilemapData(bool _hasTile)
    {
        hasTile = _hasTile;
    }
}
