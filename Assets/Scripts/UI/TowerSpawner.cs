using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] public GameObject _tower;

    private List<GameObject> _towers = new List<GameObject>();
    private bool canSpawn = false;

    private void SpawnTower()
    {
        RaycastHit info;

        int maskTower = 1 << 8;

        var placeForSpawnTower = Physics.Raycast(transform.position, Vector3.down, out info, 40, maskTower);

        if (!CheckPresentNearestTower() || _towers.Count == 0)
        {
            if (placeForSpawnTower)
            {
                GameObject tower = Instantiate(_tower, new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), Quaternion.identity);
                _towers.Add(tower);
            }
        }
    }

    private bool CheckPresentNearestTower()
    {
        bool theTowerIsNear = false;

        foreach (var tower in _towers)
        {
            if (Vector3.Distance(transform.position, tower.transform.position) < 40)
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
