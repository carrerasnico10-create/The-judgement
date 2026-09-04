using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public abstract class DiologNodeDetecter : MonoBehaviour
{
    [SerializeField] private DiologHandler dh;
    [SerializeField] private DiologNode target;
    public void OnNodeChange()
    {
        if (dh.curentNod == target)
        {
            ActionActivate();
        }
    }
    public abstract void ActionActivate();
}
