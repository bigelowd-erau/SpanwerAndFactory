using UnityEngine;
using UnityEngine.SceneManagement;


public class FactoryClient : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Spawner");
        }
    }
}
