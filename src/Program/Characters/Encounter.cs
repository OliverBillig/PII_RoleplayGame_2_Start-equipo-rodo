using System;
using System.Collections.Generic;

namespace Ucu.Poo.RoleplayGame
{
    public class Encounter
    {
        public List<Heroes> HeroesList { get; private set; } = new List<Heroes>();
        public List<Enemy> EnemyList { get; private set; } = new List<Enemy>();

        public void AddHero(Heroes hero)
        {
            if (hero != null && !HeroesList.Contains(hero))
            {
                HeroesList.Add(hero);
            }
        }

        public void AddEnemy(Enemy enemy)
        {
            if (enemy != null && !EnemyList.Contains(enemy))
            {
                EnemyList.Add(enemy);
            }
        }

        /// <summary>
        /// Ejecuta el encuentro de combate entre héroes y enemigos.
        /// </summary>
        public void DoEncounter()
        {
            // Un encuentro requiere al menos 1 Héroe y 1 Enemigo
            if (HeroesList.Count == 0 || EnemyList.Count == 0)
            {
                Console.WriteLine("No se puede iniciar el encuentro: se necesita al menos un Héroe y un Enemigo.");
                return;
            }

            // El bucle continúa mientras ambos grupos tengan al menos un participante vivo
            while (HasLivingHeroes() && HasLivingEnemies())
            {
                List<Heroes> livingHeroes = GetLivingHeroes();
                List<Enemy> livingEnemies = GetLivingEnemies();

                // 1. LOS ENEMIGOS ATACAN PRIMERO
                for (int i = 0; i < livingEnemies.Count; i++)
                {
                    if (livingHeroes.Count == 0) break;

                    Enemy enemy = livingEnemies[i];
                    // Asignación circular de héroes: el enemigo 'i' ataca al héroe 'i % N'
                    Heroes targetHero = livingHeroes[i % livingHeroes.Count];

                    targetHero.ReceiveAttack(enemy.AttackValue);
                }

                // Actualizamos la lista de héroes sobrevivientes tras el ataque enemigo
                livingHeroes = GetLivingHeroes();
                if (livingHeroes.Count == 0) break; // Si murieron todos los héroes, finaliza el encuentro

                // 2. LOS HÉROES SOBREVIVIENTES ATACAN A TODOS LOS ENEMIGOS
                foreach (Heroes hero in livingHeroes)
                {
                    // Re-obtenemos enemigos vivos para no atacar a muertos en la misma ronda
                    List<Enemy> currentLivingEnemies = GetLivingEnemies();

                    foreach (Enemy enemy in currentLivingEnemies)
                    {
                        if (enemy.Health > 0)
                        {
                            enemy.ReceiveAttack(hero.AttackValue);

                            // Si el héroe mata al enemigo, reclama sus Puntos de Victoria (VP)
                            if (enemy.Health <= 0)
                            {
                                hero.GainVP(enemy.VictoryPoints);
                            }
                        }
                    }
                }
            }

            // 3. VERIFICACIÓN Y CURACIÓN AL FINALIZAR EL ENCUENTRO
            foreach (Heroes hero in HeroesList)
            {
                // Si el héroe sobrevivió y acumuló 5 o más VP, se cura
                if (hero.Health > 0 && hero.VictoryPoints >= 5)
                {
                    hero.Cure();
                }
            }
        }

        // --- MÉTODOS AUXILIARES ---

        private bool HasLivingHeroes()
        {
            return HeroesList.Exists(h => h.Health > 0);
        }

        private bool HasLivingEnemies()
        {
            return EnemyList.Exists(e => e.Health > 0);
        }

        private List<Heroes> GetLivingHeroes()
        {
            return HeroesList.FindAll(h => h.Health > 0);
        }

        private List<Enemy> GetLivingEnemies()
        {
            return EnemyList.FindAll(e => e.Health > 0);
        }
    }
}