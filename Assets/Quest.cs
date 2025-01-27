using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Quest : MonoBehaviour
{
    public GameObject popupPanel;
    public TextMeshProUGUI questText;

    public void ShowPopup(string questTitle)
    {
        if (questText != null)
        {
            questText.text = questTitle;
        }
        popupPanel.SetActive(true); 
    }




    private void Start()
    {

        popupPanel.SetActive(true);
    }
}
