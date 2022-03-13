using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingManager : MonoBehaviour
{
   public static BuildingManager instance;
   
   private BuildingTypeScriptableObject activeBuildingType;
   private BuildingTypeListScriptableObject _buildingTypeList;
   
   private Camera mainCamera;

   public event EventHandler<OnActiveBuildingTypeChangedEventArgs> OnActiveBuildingTypeChanged;
   
   public class OnActiveBuildingTypeChangedEventArgs : EventArgs
   {
      public BuildingTypeScriptableObject activeBuildingType;
   }
   
   private void Awake()
   {
      instance = this;
      
      mainCamera = Camera.main;

      _buildingTypeList = Resources.Load<BuildingTypeListScriptableObject>(typeof(BuildingTypeListScriptableObject).Name);
      
      activeBuildingType = _buildingTypeList.list[0];
   }

   void Update()
   {
      if (Input.GetMouseButtonDown(0)  && !EventSystem.current.IsPointerOverGameObject())
      {
         Instantiate(activeBuildingType.prefab, UtilClasses.GetMousePosition(), Quaternion.identity);
         
         BuildingGhost.instance.Hide();
      }
   }

   public void SetActiveBuildingType(BuildingTypeScriptableObject buildingType)
   {
      OnActiveBuildingTypeChanged?.Invoke(this, 
         new OnActiveBuildingTypeChangedEventArgs{activeBuildingType = activeBuildingType});
     
      activeBuildingType = buildingType;
   }

   public BuildingTypeScriptableObject GetActiveBuildingType()
   {
      return activeBuildingType;
   }
}
