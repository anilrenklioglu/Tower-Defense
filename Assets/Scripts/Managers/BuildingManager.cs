using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Buildings;
using Gameplay.Buildings.Base;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingManager : MonoBehaviour
{
   public static BuildingManager instance;
   
   private BuildingTypeScriptableObject activeBuildingType;
   private BuildingTypeListScriptableObject _buildingTypeList;
   
   private Camera mainCamera;
   
   
   private void Awake()
   {
      instance = this;
      
      mainCamera = Camera.main;

      _buildingTypeList = Resources.Load<BuildingTypeListScriptableObject>(typeof(BuildingTypeListScriptableObject).Name);
      
      activeBuildingType = _buildingTypeList.list[0];
   }

   public void CreateGhost(BuildingType type)
   {
      BuildingTypeScriptableObject newObj = null;
      for (int i = 0; i < _buildingTypeList.list.Count; i++)
      {
         if (_buildingTypeList.list[i].buildingBase.myType == type)
         {
            newObj = _buildingTypeList.list[i];
            break;
         }
      }
      
      BuildingEventManager.instance.GhostCreationEventCallback(newObj);
      
   }

   public void CreateBuilding(BuildingBase @base)
   {
      Instantiate(@base.gameObject, UtilClasses.GetMousePosition(), Quaternion.identity);
         
      BuildingGhost.instance.Hide();
      
   }
   

   public BuildingTypeScriptableObject GetActiveBuildingType()
   {
      return activeBuildingType;
   }
}
