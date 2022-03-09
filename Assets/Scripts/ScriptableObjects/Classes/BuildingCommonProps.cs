using UnityEngine;

namespace ScriptableObjects.Classes
{
    [CreateAssetMenu(fileName = "Props", menuName = "ScriptableObjects/Buildings", order = 0)]
    public class BuildingCommonProps : ScriptableObject
    {
        public float cost;
        public int gridScale;
    }
}