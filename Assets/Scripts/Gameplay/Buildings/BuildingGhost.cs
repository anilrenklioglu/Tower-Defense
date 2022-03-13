using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGhost : MonoBehaviour
{
    public static BuildingGhost instance;
    
    private GameObject spriteGameObject;
    
    private void Awake()
    {
        instance = this;
        
        spriteGameObject = transform.Find("sprite").gameObject;
        
        Hide();
    }

    private void Start()
    {
        BuildingManager.instance.OnActiveBuildingTypeChanged += BuildingManager_OnActiveBuildingTypeChanged;
    }

    private void BuildingManager_OnActiveBuildingTypeChanged(object sender, BuildingManager.OnActiveBuildingTypeChangedEventArgs e)
    {
        if (e.activeBuildingType == null)
        {
            Hide();
        }

        else
        {
            Show(e.activeBuildingType.sprite);
        }
    }

    private void Update()
    {
        transform.position = UtilClasses.GetMousePosition();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Hide();
        }
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
