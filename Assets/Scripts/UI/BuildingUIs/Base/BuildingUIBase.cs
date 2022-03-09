using ScriptableObjects.Classes;
using UnityEngine;

namespace UI.BuildingUIs.Base
{
    public abstract class BuildingUIBase : MonoBehaviour
    {
        public BuildingCommonProps CommonProps { get; set; }
        
        public virtual void SetUIActivation()
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}