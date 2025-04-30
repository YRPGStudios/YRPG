using UnityEngine;
using UnityEngine.SceneManagement;
public class GameVersions : MonoBehaviour
{
    public string YRPG1Scene;

    public string YRPG2Scene;

    public string YRPG3Scene;

    public string YRPG4Scene;

    // Update is called once per frame
  
    public void YRPG1SceneChange()
    {

       SceneManager.LoadScene(YRPG1Scene);

    }
    public void YRPG2SceneChange()
    {

        SceneManager.LoadScene(YRPG2Scene);

    }
    public void YRPG3SceneChange()
    {

        SceneManager.LoadScene(YRPG3Scene);

    }
    public void YRPG4SceneChange()
    {

        SceneManager.LoadScene(YRPG4Scene);

    }
}
