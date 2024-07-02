using UnityEngine;

public class InstructionUI : MonoBehaviour
{
    void Start()
    {
        Show();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Hide();
        }
    }
    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
