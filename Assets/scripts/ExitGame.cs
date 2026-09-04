using UnityEngine;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class ExitGame : DiologNodeDetecter
{

    public override void ActionActivate()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;

#else
        Application.Quit();
#endif
    }
    
}
