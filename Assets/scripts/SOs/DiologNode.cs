using UnityEngine;
using UnityEngine.Events;
using System;
[CreateAssetMenu(menuName ="SOs/Diolog/node" , fileName ="diolog node")]
public class DiologNode : ScriptableObject
{
    [TextArea(3,10)]
    public string listenDiolog;
    public DiologOptions[] options;
    public UnityEvent inWorldActions;
}
[Serializable]
public class DiologOptions
{
    [TextArea (3,10)]
    public string PlayerSpeaks;
    public DiologNode resolt;
}
