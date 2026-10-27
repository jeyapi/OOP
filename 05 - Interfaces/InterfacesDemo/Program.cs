using InterfacesDemo.Classes;
using InterfacesDemo.Interfaces;

Knight knight = new Knight();

IAttack attackInterface = knight;
attackInterface.Attack();

IDefend defendInterface = knight;
defendInterface.Attack();