using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public iCopyable m_Copy;

    public Enemy SpawnEnemy(Enemy prototype)
    {
        m_Copy = prototype.Copy();
        return (Enemy)m_Copy;
    }

    public Enemy LoadEnemy(Enemy type)
    {
        m_Copy = type.Create();
        return (Enemy)m_Copy;
    }
}
