using System;
using Managers;
using UnityEngine;
using UnityEngine.UI;


namespace UI.BuildingUIs.Base
{
    public abstract class BuildingButtonBase : MonoBehaviour
    {
        [SerializeField] private BuildingTypeScriptableObject myType;
        [SerializeField] private Image _image;
        
        private Sprite sprite;
        private Button button;
        
        protected virtual void Awake()
        {
            button = GetComponent<Button>();
        }

        protected virtual void Start()
        {
            sprite = myType.sprite;
            
            _image.sprite = sprite;
            button.onClick.AddListener(Click);
        }

        protected virtual void Click()
        {
            UserInputController.instance.BuildingSelection(myType.buildingBase,InputStates.BuildingState);
        }
    }
}