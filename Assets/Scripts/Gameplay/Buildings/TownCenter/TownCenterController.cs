using System;
using Gameplay.Buildings.Base;
using UI.BuildingUIs.EventManager;
using UnityEngine;

namespace Gameplay.Buildings.TownCenter
{
    public class TownCenterController : BuildingBase
    {
        protected override void MouseClickToObject()
        {
            BuildingsEventManager.instance.OnMouseClicked(this);
        }
    }
}