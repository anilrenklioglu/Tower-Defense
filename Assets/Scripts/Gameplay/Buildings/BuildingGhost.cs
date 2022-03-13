using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Buildings;
using Gameplay.Buildings.Base;
using UnityEngine;

public class BuildingGhost : MonoBehaviour
{
    public static BuildingGhost instance;
    
    [SerializeField] private GameObject spriteGameObject;
    
    private void Awake()
    {
        instance = this;
        Hide();
    }

    private void OnEnable()
    {
        BuildingEventManager.GhostCreationEvent += BuildingEventManagerOnGhostCreationEvent;
    }

    private void BuildingEventManagerOnGhostCreationEvent(BuildingTypeScriptableObject building)
    {
        Show(building.sprite);
    }
    
    private void Update()
    {
        transform.position = UtilClasses.GetMousePosition();
    }

    private void Show(Sprite ghostSprite)
    {
        spriteGameObject.SetActive(true);

        spriteGameObject.GetComponent<SpriteRenderer>().sprite = ghostSprite; 
    }

    public void Hide()
    {
        spriteGameObject.SetActive(false);
    }
    
   
}
