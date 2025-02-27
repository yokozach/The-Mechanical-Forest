using System.Collections.Generic;
using UnityEngine;

namespace Akashic.ScriptableObjects.Config
{
    /// <summary>
    /// Configuration data for the game.
    /// </summary>
    [CreateAssetMenu(menuName = "Akashic/Config/New Save Config Settings")]
    public sealed class SaveConfigData : ScriptableObject
    {
        /// <summary>
        /// The parent folder in Application.persistentDataPath where all save folders will be stored.
        /// </summary>
        public string parentSaveFolderName;
        
        /// <summary>
        /// The name of a folder correlating to an individual save slot.
        /// </summary>
        public List<string> saveFolderNames = new List<string>();
        
        /// <summary>
        /// The name of a save file correlating to an individual save slot.
        /// </summary>
        public List<string> saveFileNames = new List<string>();

        /// <summary>
        /// Number of characters allowed for a save slot name.
        /// </summary>
        public int saveSlotNameCharacterLimit = 16;
    }
}