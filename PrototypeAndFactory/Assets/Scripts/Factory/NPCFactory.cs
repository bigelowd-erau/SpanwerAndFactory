using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCType.Shopowner:
                INPC shopowner = new Shopowner();
                return shopowner;
            case NPCType.Blacksmith:
                INPC blacksmith = new Blacksmith();
                return blacksmith;
            case NPCType.Guard:
                INPC guard = new Guard();
                return guard;
            case NPCType.Child:
                INPC child = new Child();
                return child;
            case NPCType.Dog:
                INPC dog = new Dog();
                return dog;
        }
        return null;
    }
}
