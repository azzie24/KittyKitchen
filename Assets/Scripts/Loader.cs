using UnityEngine.SceneManagement;

public static class Loader
{


    public enum Scene
    {
        MainMenuScene,
        GameScene,
        GameScene_level2,
        GameScene_level3,
        LoadingScene,
        LevelSelection
    }


    private static Scene targetScene;



    public static void Load(Scene targetScene)
    {
        Loader.targetScene = targetScene;

        SceneManager.LoadScene(Scene.LoadingScene.ToString());
    }

    public static void LoaderCallback()
    {
        SceneManager.LoadScene(targetScene.ToString());
    }

}