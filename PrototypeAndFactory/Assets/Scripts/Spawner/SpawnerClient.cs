using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnerClient : MonoBehaviour
{
    public Drone m_Drone;
    public Sniper m_Sniper;
    public Wendigo m_Wendigo;
    public EnemySpawner m_Spawner;
    public CameraMovement main_camera;
    public Toggle toggle;

    private Enemy m_Spawn;
    private int m_IncrementorDrone = 0;
    private int m_IncrementorSniper = 0;
    private int m_IncrementorWendigo = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Spawn = CreateEnemy(m_Drone);
            m_Spawn.name = "Drone Clone_" + ++m_IncrementorDrone;
            m_Spawn.transform.Translate(Vector3.right * m_IncrementorDrone * 1.5f);
            main_camera.MoveBack();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawn = m_Spawn = m_Spawn = CreateEnemy(m_Sniper);
            m_Spawn.name = "Sniper Clone_" + ++m_IncrementorSniper;
            m_Spawn.transform.Translate(Vector3.left * m_IncrementorSniper * 1.5f);
            main_camera.MoveBack();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            m_Spawn = CreateEnemy(m_Wendigo);
            m_Spawn.name = "Wendigo Clone_" + ++m_IncrementorWendigo;
            m_Spawn.transform.Translate(Vector3.up * m_IncrementorWendigo * 1.5f);
            main_camera.MoveBack();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Factory");
        }
    }

    Enemy CreateEnemy(Enemy enemy)
    {
        if (toggle.isOn)
        {
            Debug.Log("Cloned enemy");
            return m_Spawner.SpawnEnemy(enemy);
        }
        else
        {
            Debug.Log("Loaded enemy");
            return m_Spawner.LoadEnemy(enemy);
        }
    }
}
