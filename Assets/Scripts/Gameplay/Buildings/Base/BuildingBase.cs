using System;
using ScriptableObjects.Classes;
using UnityEngine;

namespace Gameplay.Buildings.Base
{
    public abstract class BuildingBase : MonoBehaviour
    {
        public BuildingType buildingType;
        public int buildingID;
        public BuildingCommonProps commonProps;
        
        protected virtual void OnMouseDown()
        {
            MouseClickToObject();
        }

        protected abstract void MouseClickToObject();
    }
}