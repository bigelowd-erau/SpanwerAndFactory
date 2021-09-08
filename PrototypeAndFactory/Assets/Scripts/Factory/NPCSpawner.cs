using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    private INPC m_Blacksmith;
    private INPC m_Guard;
    private INPC m_Child;
    private INPC m_Dog;

    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        m_Blacksmith = m_Factory.GetNPC(NPCType.Blacksmith);
        m_Guard = m_Factory.GetNPC(NPCType.Guard);
        m_Child = m_Factory.GetNPC(NPCType.Child);
        m_Dog = m_Factory.GetNPC(NPCType.Dog);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();
        m_Blacksmith.Speak();
        m_Guard.Speak();
        m_Child.Speak();
        m_Dog.Speak();
    }
}
