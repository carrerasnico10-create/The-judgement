using UnityEngine;

public class ActivationObjectControl : DiologNodeDetecter
{
    [SerializeField] private GameObject GOtarget;
    [SerializeField] private bool active;
    public override void ActionActivate()
    {
        GOtarget.SetActive(active);
    }
}
