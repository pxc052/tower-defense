using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    public TurretBluePrint standarTurret;
    public TurretBluePrint missileLauncher;
    public TurretBluePrint laserBeamer;
    // Start is called before the first frame update
    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        buildManager.SelectTurretToBuild(standarTurret);
    }

    public void SelectMissileLaucher()
    {
        buildManager.SelectTurretToBuild(missileLauncher);
    }

    public void SelectLaserBeamer()
    {
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
