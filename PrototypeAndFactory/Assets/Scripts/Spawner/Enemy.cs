using UnityEngine;

public class Enemy : MonoBehaviour, iCopyable
{
    public iCopyable Copy()
    {
        return Instantiate(this);
    }

    public iCopyable Create()
    {
        return Instantiate(Resources.Load<Enemy>("Prefabs/" + this.name));
    }
}
