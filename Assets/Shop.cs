using UnityEngine;
public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint cannonLauncher;
	public TurretBlueprint crystalBeamer;

	BuildManager buildManager;

	void Start ()
	{
		buildManager = BuildManager.instance;
	}
	public void SelectStandardTurret ()
	{
		Debug.Log("Standard Turret Selected");
		buildManager.SelectTurretToBuild(standardTurret);
	}
	public void SelectCannonLauncher()
	{
		Debug.Log("Cannon Launcher Selected");
		buildManager.SelectTurretToBuild(cannonLauncher);
	}

	public void SelectLaserBeamer()
	{
		Debug.Log("Crystal Beamer Selected");
		buildManager.SelectTurretToBuild(crystalBeamer);
	}

}