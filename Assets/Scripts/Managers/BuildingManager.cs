using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{

   private BuildingTypeScriptableObject buildingType;
   private BuildingTypeListScriptableObject _buildingTypeList;
   
   private Camera mainCamera;
   
   private void Start()
   {
      mainCamera = Camera.main;

      _buildingTypeList = Resources.Load<BuildingTypeListScriptableObject>(typeof(BuildingTypeListScriptableObject).Name);
      buildingType = _buildingTypeList.list[0];
   }

   void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         Instantiate(buildingType.prefab, GetMousePosition(), Quaternion.identity);
      }

      if (Input.GetKeyDown(KeyCode.D))
      {
         buildingType = _buildingTypeList.list[0];
      }
      
      if (Input.GetKeyDown(KeyCode.A))
      {
         buildingType = _buildingTypeList.list[2];
      }
   }

   private Vector3 GetMousePosition()
   {
      Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

      mousePos.z = 0f;

      return mousePos;
   }
}
