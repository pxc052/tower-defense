using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    // Singleton
    public static BuildManager instance;
    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;
    private GameObject turretToBuild;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("ore than one BuildManager in scene");
            return;
        }
        instance = this;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
