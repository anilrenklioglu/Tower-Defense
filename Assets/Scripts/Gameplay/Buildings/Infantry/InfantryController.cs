using Gameplay.Buildings.Base;
using UI.BuildingUIs.EventManager;

namespace Gameplay.Buildings.Infantry
{
    public class InfantryController : BuildingBase
    {
        protected override void MouseClickToObject()
        {
            BuildingsEventManager.instance.OnMouseClicked(this);
        }
    }
}