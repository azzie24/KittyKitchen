using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelSelectionUI : MonoBehaviour

{
    [SerializeField] private Button level1Button;
    [SerializeField] private Button level2Button;
    [SerializeField] private Button level3Button;
    [SerializeField] private Button backButton;


    private void Awake()
    {
        level1Button.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.GameScene);
        });
        level2Button.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.GameScene_level2);
        });
        level3Button.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.GameScene_level3);
        });
        backButton.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.MainMenuScene);
        });
        Time.timeScale = 1f;
    }
}
