using System;
namespace Ucu.Poo.RoleplayGame;

public interface ICharacter
{
    string Name { get; }

    int Health { get; }

    int AttackValue { get; }

    int DefenseValue { get; }

    void ReceiveAttack(int damage);

    void Cure();
}