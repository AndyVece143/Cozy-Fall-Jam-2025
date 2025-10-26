using UnityEngine;

public class Menus : MonoBehaviour
{
    public LevelLoader loader;

    public void PlayButton()
    {
        loader.LoadNextLevel("Opening");
    }

    public void CreditsButton()
    {
        loader.LoadNextLevel("Credits");
    }

    public void TitleButton()
    {
        loader.LoadNextLevel("Title");
    }
}
