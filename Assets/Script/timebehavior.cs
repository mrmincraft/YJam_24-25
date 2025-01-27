using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timebehavior : MonoBehaviour
{
    [SerializeField] private float targetTime = 10.0f;
    [SerializeField] private TMP_Text TimeText;
    [SerializeField] private bool pause;
    //private float fillpersent = 0 ;
   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
    {
        TimeText.text = targetTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause)
        {
            targetTime -= Time.deltaTime;
            TimeText.text = targetTime.ToString();

            if (targetTime <= 0.0f)
            {
                timerEnded();
                
            }
        }
    }

    void timerEnded()
    {
        TimeText.text = "0.000";
        pause = true;
        SceneManager.LoadScene("MainMenu");
    }
}
