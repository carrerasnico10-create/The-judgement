using System;
using System.Reflection.Emit;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DiologHandler : MonoBehaviour
{
    public DiologNode rootNod;
    private DiologNode curentNod;
    public GameObject buttonPrefab;
    private Button button;
    public Transform options;
    private Action[] buttionListenerRe;
    public TMP_Text speaker;
    public bool debug = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        curentNod = rootNod;
        SetupUI();
        
    }
    private void SetupUI()
    {
        RemoveButtons();
        speaker.text = curentNod.listenDiolog;
        AddButtons();
        Canvas.ForceUpdateCanvases();

        if (debug)
        {
            Debug.Log($"curent nod;{curentNod.name}");
            foreach(DiologOptions option in curentNod.options)
            {
                Debug.Log($"options;{option.resolt.name}");
            }
        }
    }
    public void OnClick(int option)
    {
        curentNod = curentNod.options[option].resolt;
        SetupUI();
        curentNod.inWorldActions.Invoke();
    }
    private void RemoveButtons()
    {
        int temp = options.childCount;
        for (int i = temp-1; i >= 0; i--)
        {
            button = options.GetChild(i).GetComponent<Button>();
            button.onClick.RemoveAllListeners();
            GameObject tb = options.GetChild(i).gameObject;
            Destroy(tb);
        }
    }
    private void AddButtons()
    {
        for (int i = 0; i < curentNod.options.Length; i++)
        {
            int index = i;
            GameObject tempbutton = Instantiate(buttonPrefab, options);
            button = tempbutton.GetComponent<Button>();
            if (curentNod.options[i]==null|| curentNod.options[i].resolt==null)
            {
                button.interactable = false;
            }
            button.onClick.AddListener(() => OnClick(index));
            //Debug.Log($"button.onClick.AddListener(() => OnClick({index}));");
            GameObject lable = tempbutton.transform.GetChild(0).gameObject;
            lable.GetComponent<TMP_Text>().text = curentNod.options[i].PlayerSpeaks;
        }
    }
    private void OnDisable()
    {
        RemoveButtons();
        
    }
}
