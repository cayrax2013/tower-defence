using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TextMesh))]
public class DisplayEnemyHealth : MonoBehaviour
{
    [SerializeField] private Image _healthBar;

    private TextMesh _display;

    private void Start()
    {
        _display = GetComponent<TextMesh>();
    }

    public void DisplayHealthBar(float value)
    {
        _healthBar.fillAmount = value;
    }
}
