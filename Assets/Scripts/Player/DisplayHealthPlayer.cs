using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealthPlayer : MonoBehaviour
{
    [SerializeField] private Image _healthBarl;

    public void Display(float value)
    {
        _healthBarl.fillAmount = value;
    }
}
 