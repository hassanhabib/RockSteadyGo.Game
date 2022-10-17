using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class PlayerBaseComponent : MonoBehaviour
{
    private TMP_Text label;

    public string PlayerName
    {
        get => label.text;
        set => label.text = value;
    }

    private void Awake()
    {
        label = GetComponent<TMP_Text>();
    }
}