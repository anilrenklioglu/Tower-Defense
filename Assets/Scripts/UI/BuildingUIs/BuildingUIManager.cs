using System;
using Gameplay.Buildings.Base;
using UI.BuildingUIs.EventManager;
using UI.BuildingUIs.MilitaryBuildings;
using UI.BuildingUIs.TownCenter;
using UnityEngine;
using Utilities;

namespace UI.BuildingUIs
{
    public class BuildingUIManager : Singleton<BuildingUIManager>
    {
        private InfantryUIController _infantryUIController;
        private TownCenterUIController _townCenterUIController;
        
        private void Awake()
        {
            Cache();
        }

        void Cache()
        {
            _townCenterUIController = GetComponentInChildren<TownCenterUIController>(true);
            _infantryUIController = GetComponentInChildren<InfantryUIController>(true);
        }

        private void OnEnable()
        {
            BuildingsEventManager.OnMouseClickEvent += BuildingsEventManagerOnOnMouseClickEvent;    
        }
        private void OnDisable()
        {
            BuildingsEventManager.OnMouseClickEvent -= BuildingsEventManagerOnOnMouseClickEvent;  
        }
        
        private void BuildingsEventManagerOnOnMouseClickEvent(BuildingBase buildingBase)
        {
            
            switch (buildingBase.buildingType)
            {
                case BuildingType.TownCenter:
                    _townCenterUIController.CommonProps = buildingBase.commonProps;
                    _townCenterUIController.SetUIActivation();
                    break;
                case BuildingType.Infantry:
                    _infantryUIController.CommonProps = buildingBase.commonProps;
                    _infantryUIController.SetUIActivation();
                    break;
            }
        }
        
        
    }
}