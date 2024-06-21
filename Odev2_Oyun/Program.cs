namespace Odev2_Oyun;

// Delegate tanımlamaları
public delegate void HealthChangedEventHandler(object sender, HealthChangedEventArgs e);
public delegate void EnemyKilledEventHandler(object sender, EventArgs e);

// EventArgs türeten özel sınıf
public class HealthChangedEventArgs(int currentHealth) : EventArgs
{
    public int CurrentHealth { get; } = currentHealth;
}

// Character sınıfı
public class Character
{
    private int health;

    // Event tanımlamaları
    public event HealthChangedEventHandler? HealthChanged;
    public event EnemyKilledEventHandler? EnemyKilled;

    // Can seviyesi property
    public int Health
    {
        get { return health; }
        set
        {
            health = value;
            OnHealthChanged(new HealthChangedEventArgs(health));

            if (health < 20)
            {
                Console.WriteLine("Uyarı: Sağlık durumu kritik seviyede!");
            }
        }
    }

    // Sağlık değiştiğinde çağrılacak metod
    protected virtual void OnHealthChanged(HealthChangedEventArgs e)
    {
        HealthChanged?.Invoke(this, e);
    }

    // Düşman öldürüldüğünde çağrılacak metod
    public void KillEnemy()
    {
        Console.WriteLine("Bir düşman öldürüldü.");
        OnEnemyKilled(EventArgs.Empty);
    }

    protected virtual void OnEnemyKilled(EventArgs e)
    {
        EnemyKilled?.Invoke(this, e);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Character hero = new Character();
            
        // Event abonelikleri
        hero.HealthChanged += Hero_HealthChanged;
        hero.EnemyKilled += Hero_EnemyKilled;

        // Sağlık seviyesini değiştir ve düşman öldür
        hero.Health = 50;
        hero.Health = 15;  // Kritik seviye uyarısı tetiklenecek
        hero.KillEnemy();
    }

    private static void Hero_HealthChanged(object sender, HealthChangedEventArgs e)
    {
        Console.WriteLine($"Kahramanın sağlık bilgisi: {e.CurrentHealth}");
    }

    private static void Hero_EnemyKilled(object sender, EventArgs e)
    {
        Console.WriteLine("Bir düşman öldürüldü.");
    }
}