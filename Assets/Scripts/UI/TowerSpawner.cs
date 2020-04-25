using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _tower;
    [SerializeField] private Gold _gold;
    [SerializeField] private int _priceForTower = 100;

    private List<GameObject> _towers = new List<GameObject>();

    private void SpawnTower()
    {
        int maskTower = 1 << 8;

        var placeForSpawnTower = Physics.Raycast(transform.position, Vector3.down, 40, maskTower);

        if (!CheckPresentNearestTower() || _towers.Count == 0)
        {
            if (placeForSpawnTower)
            {
                if (PlayerPrefs.GetInt("currentGold") >= 100)
                {
                    _gold.TakeGold(-_priceForTower);
                    GameObject tower = Instantiate(_tower, new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z + 2.3f), Quaternion.identity);
                    _towers.Add(tower);
                }
            }
        }
    }

    private bool CheckPresentNearestTower()
    {
        bool theTowerIsNear = false;

        foreach (var tower in _towers)
        {
            if (Vector3.Distance(transform.position, tower.transform.position) < 10)
            {
                theTowerIsNear = true;
            }
        }

        return theTowerIsNear;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpawnTower();
        }
    }
}
