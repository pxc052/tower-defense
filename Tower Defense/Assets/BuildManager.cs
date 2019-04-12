using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    // Singleton
    public static BuildManager instance;
    public GameObject standardTurretPrefab;
    private GameObject turretToBuild;

    void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("ore than one BuildManager in scene");
            return;
        }
        instance = this;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
