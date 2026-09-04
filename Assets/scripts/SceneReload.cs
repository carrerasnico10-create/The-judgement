using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneReload : DiologNodeDetecter
{
    [SerializeField] private int sceneIndex;
    public override void ActionActivate()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
