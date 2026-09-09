using UnityEngine;
using UnityEngine.InputSystem;

public class OptionsToggler : MonoBehaviour
{
    private bool toggle = false;
    [SerializeField] private GameObject options;
    [SerializeField] private GameObject insructions;

    public void ToggleMethode(InputAction.CallbackContext cbc)
    {
        if(cbc.started)
        {
            toggle = !toggle;
            options.SetActive(toggle);
            insructions.SetActive(!toggle);
        }
    }
}
