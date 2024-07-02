using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Tim
{
    public class GamePlayingClockUI : MonoBehaviour
    {
        [SerializeField] private Text timeText;

        private float currentTime = -1;

        [SerializeField] private float duration;

        void Start()
        {
            currentTime = duration;
            timeText.text = currentTime.ToString();
            StartCoroutine(UpdateTime());
        }

        private IEnumerator UpdateTime()
        {

            while (currentTime > -1)
            {
                timeText.text = currentTime.ToString();
                yield return new WaitForSeconds(1f);
                currentTime--;
            }

            yield return null;
        }

        public float GetCurrentTime()
        {
            return currentTime;
        }
    }
}