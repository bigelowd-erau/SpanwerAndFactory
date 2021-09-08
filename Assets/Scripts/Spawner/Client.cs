using UnityEngine;

public class Client : MonoBehaviour
{
    public Drone m_Drone;
    public Sniper m_Sniper;
    public EnemySpawner m_Spawner;

    private Enemy m_Spawn;
    private int m_IncrementorDrone = 0;
    private int m_IncrementorSniper = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Drone);
            m_Spawn.name = "Drone Clone_" + ++m_IncrementorDrone;
            m_Spawn.transform.Translate(Vector3.right * m_IncrementorDrone * 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Sniper);
            m_Spawn.name = "Sniper Clone_" + ++m_IncrementorSniper;
            m_Spawn.transform.Translate(Vector3.left * m_IncrementorSniper * 1.5f);
        }
    }
}
