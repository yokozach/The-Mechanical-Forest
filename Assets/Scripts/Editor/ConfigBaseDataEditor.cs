using Akashic.ScriptableObjects.Config;
using UnityEditor;

namespace Akashic.Editor
{
    [CustomEditor(typeof(SaveConfigData))]
    internal sealed class ConfigBaseDataEditor : UnityEditor.Editor
    {
        private SerializedProperty parentSaveFolderNameProp;
        private SerializedProperty saveFolderNamesProp;
        private SerializedProperty saveFileNamesProp;        
        private SerializedProperty saveSlotNameCharacterLimitProp;


        void OnEnable()
        {
            parentSaveFolderNameProp = serializedObject.FindProperty("parentSaveFolderName");
            saveFolderNamesProp = serializedObject.FindProperty("saveFolderNames");
            saveFileNamesProp = serializedObject.FindProperty("saveFileNames");
            saveSlotNameCharacterLimitProp = serializedObject.FindProperty("saveSlotNameCharacterLimit");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
        
            EditorGUI.BeginChangeCheck();
        
            EditorGUILayout.PropertyField(parentSaveFolderNameProp, true);
            EditorGUILayout.PropertyField(saveFolderNamesProp, true);
            EditorGUILayout.PropertyField(saveFileNamesProp, true);
            EditorGUILayout.PropertyField(saveSlotNameCharacterLimitProp, true);
        
            if (EditorGUI.EndChangeCheck())
            {
                while (saveFolderNamesProp.arraySize > 3)
                {
                    saveFolderNamesProp.DeleteArrayElementAtIndex(saveFolderNamesProp.arraySize - 1);
                }
            
                while (saveFileNamesProp.arraySize > 3)
                {
                    saveFileNamesProp.DeleteArrayElementAtIndex(saveFileNamesProp.arraySize - 1);
                }
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}

