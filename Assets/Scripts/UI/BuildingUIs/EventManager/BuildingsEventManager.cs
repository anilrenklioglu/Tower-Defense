using Gameplay.Buildings.Base;
using UnityEngine;
using Utilities;

namespace UI.BuildingUIs.EventManager
{
    public class BuildingsEventManager : Singleton<BuildingsEventManager>
    {
        public delegate void OnMouseClick(BuildingBase buildingBase);
        public static event OnMouseClick OnMouseClickEvent;

        public void OnMouseClicked(BuildingBase buildingBase)
        {
            OnMouseClickEvent?.Invoke(buildingBase);
        }
    }
}