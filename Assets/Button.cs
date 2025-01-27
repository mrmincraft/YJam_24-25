using System;
using Unity.VisualScripting;
using UnityEngine;

public class Button : Quest
{
    void Start()
    {
        
    }
    public void HidePopup()
    {
        popupPanel.SetActive(false);
        questText.text = "";
    }

    void Update()
    {
        OnButtonClick(HidePopup());
    }

}
