using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGold : MonoBehaviour
{
    [SerializeField] private Text _display;
    [SerializeField] private string _pattern = "Gold: {0}";

    public void Display(int value)
    {
        _display.text = string.Format(_pattern, value);
    }
}
