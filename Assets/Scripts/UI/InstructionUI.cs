using UnityEngine;

public class InstructionUI : MonoBehaviour
{
    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        Show();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            // Check if the "E" key is pressed
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Call the Hide method to close the UI

                Hide();
            }
        }
    }
}