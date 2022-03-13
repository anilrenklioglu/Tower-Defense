using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingTypeSelectUI : MonoBehaviour
{
   
   private void Awake()
   {
      Transform buttonTemplate = transform.Find("ButtonTemplate");
      
      buttonTemplate.gameObject.SetActive(false);
      
      BuildingTypeListScriptableObject _buildingTypeList = Resources.Load<BuildingTypeListScriptableObject>(typeof(BuildingTypeListScriptableObject).Name);

      int index = 0;
      
      foreach (BuildingTypeScriptableObject buildingType in _buildingTypeList.list)
      {
         Transform buttonTransform = Instantiate(buttonTemplate, transform);
         
         buttonTransform.gameObject.SetActive(true);

         float offset = 100f;

         buttonTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(offset * index, 0);

         buttonTransform.Find("image").GetComponent<Image>().sprite = buildingType.sprite;

         buttonTransform.GetComponent<Button>().onClick.AddListener(() =>
         {
            BuildingManager.instance.SetActiveBuildingType(buildingType);
         } );

         index++; 


      }
   }
}
