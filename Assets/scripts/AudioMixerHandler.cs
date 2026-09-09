using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerHandler : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private string peram;

    public void VolumChange(float v)
    {
        float i = Mathf.Log10(Mathf.Clamp(v, 0.0001f, 1f))*20;
        mixer.SetFloat(peram, i);
    }
}
