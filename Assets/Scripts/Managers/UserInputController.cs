using System;
using Gameplay.Buildings.Base;
using UnityEngine;
using Utilities;

namespace Managers
{
    public class UserInputController : Singleton<UserInputController>
    {
        private InputStates currentState;
        public BuildingBase selectedBuilding;
        // public MilitaryUnitBase selectedUnit;

        #region UnityEvents
        protected override void AwakeEx()
        {
            base.AwakeEx();
            currentState = InputStates.Wait;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (currentState == InputStates.BuildingState)
                {
                    if (!selectedBuilding) return;

                    BuildingCreation();
                }
            }

            if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Escape))
            {
                CancelSelection();
            }
        }

        

        #endregion

        #region BuildingSelection
        public void BuildingSelection(BuildingBase building, InputStates state)
        {
            if(currentState != InputStates.Wait) return;
           
            currentState = state;
            selectedBuilding = building;
            
            BuildingManager.instance.CreateGhost(building.myType);
        }

        private void BuildingCreation()
        {
            if(!selectedBuilding) return;
            
            BuildingManager.instance.CreateBuilding(selectedBuilding);

            selectedBuilding = null;
            currentState = InputStates.Wait;
        }
        #endregion

        void CancelSelection()
        {
            if (selectedBuilding)
            {
                selectedBuilding = null;
                BuildingGhost.instance.Hide();
                currentState = InputStates.Wait;
            }
        }
    }
}