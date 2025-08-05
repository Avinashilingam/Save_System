using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveManager : MonoBehaviour
{
    public TextMeshProUGUI saveText;

    public void SaveData()
    {
        // Example save data logic
        PlayerPrefs.SetString("PlayerName", saveText.text);
        Debug.Log($"Saved Data: Name = {saveText.text}");
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            string playerName = PlayerPrefs.GetString("PlayerName");
            Debug.Log($"Loaded Data: Name = {playerName}");
        }
        else
        {
            Debug.Log("No save data found.");
        }
    }
    
    public void ClearData()
    {
        PlayerPrefs.DeleteKey("PlayerName");
        Debug.Log("Save data cleared.");
    }

  

}
