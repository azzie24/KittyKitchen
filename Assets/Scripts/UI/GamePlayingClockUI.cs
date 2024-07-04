using UnityEngine;
using UnityEngine.UI;


public class GamePlayingClockUI : MonoBehaviour
{


    [SerializeField] private Text timerText;


    private void Update()
    {
        timerText.text = KitchenGameManager.Instance.GetGamePlayingTimerNormalized().ToString();
    }
}

