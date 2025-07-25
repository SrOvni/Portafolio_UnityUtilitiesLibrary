namespace UtilitiesLibrary
{
    using UnityEngine;
    using UnityEditor;
    using System;
    using UnityEngine.UI;

    [CustomPropertyDrawer(typeof(RequiredFieldAttribute))]
    public class RequiredFieldDrawer : PropertyDrawer
    {

        private void Awake()
        {
            Button button = new GameObject("Button").AddComponent<Button>();
            button.onClick.AddListener(() => Debug.Log("Hola mundo"));


        }


    }

    [AttributeUsage(AttributeTargets.Field)]
    internal class RequiredFieldAttribute : PropertyAttribute
    {

    }
}
