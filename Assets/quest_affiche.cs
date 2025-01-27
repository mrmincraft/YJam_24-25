using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    public Quest popupManager;

    public void TriggerQuest()
    {
        popupManager.ShowPopup("Quête");
    }
}
