using System.Collections;
using System.Collections.Generic;
using Gameplay.Buildings.Base;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects / BuildingType")]
public class BuildingTypeScriptableObject : ScriptableObject
{
    public BuildingBase buildingBase; 
    public string nameString;

    public Transform prefab;
    
    public int cost;

    public Sprite sprite;
}
