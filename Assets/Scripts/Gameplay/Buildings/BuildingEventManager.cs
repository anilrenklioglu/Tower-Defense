using Gameplay.Buildings.Base;
using JetBrains.Annotations;
using UnityEngine;
using Utilities;

namespace Gameplay.Buildings
{
    public class BuildingEventManager : Singleton<BuildingEventManager>
    {
        public delegate void  BuildingGhostCreation(BuildingTypeScriptableObject building);

        public static event BuildingGhostCreation GhostCreationEvent;
        
        public void GhostCreationEventCallback(BuildingTypeScriptableObject building)
        {
            GhostCreationEvent?.Invoke(building);
        }
    }
}