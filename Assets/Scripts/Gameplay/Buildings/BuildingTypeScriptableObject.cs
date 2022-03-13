using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects / BuildingType")]
public class BuildingTypeScriptableObject : ScriptableObject
{
    public string nameString;

    public Transform prefab;
    
    public int cost;

    public Sprite sprite;
}
