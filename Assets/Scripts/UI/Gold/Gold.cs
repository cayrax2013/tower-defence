using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventInt: UnityEvent<int> { }

public class Gold : MonoBehaviour
{
    [SerializeField] private int _currentGold;
    [SerializeField] private UnityEventInt _amountColdChanged;

    private void Start()
    {
        _amountColdChanged?.Invoke(_currentGold);
        PlayerPrefs.SetInt("currentGold", _currentGold);
    }

    public void TakeGold(int gold)
    {
        _currentGold += gold;
        PlayerPrefs.SetInt("currentGold", _currentGold);
        _amountColdChanged?.Invoke(_currentGold);

    }
}
