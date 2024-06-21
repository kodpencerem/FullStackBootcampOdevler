namespace Odev2_FinansApp;

// Delegate tanımı
public delegate void BalanceChangedEventHandler(object sender, EventArgs e);
public delegate void LargeTransactionEventHandler(object sender, EventArgs e);

// Banka Hesabı sınıfı
public class BankAccount
{
    // Olaylar
    public event BalanceChangedEventHandler BalanceChanged;
    public event LargeTransactionEventHandler LargeTransactionOccurred;

    private decimal _balance;
    private decimal _transactionThreshold;

    // Yapıcı metot
    public BankAccount(decimal initialBalance, decimal transactionThreshold)
    {
        _balance = initialBalance;
        this._transactionThreshold = transactionThreshold;
    }

    // Bakiye özelliği
    public decimal Balance
    {
        get { return _balance; }
        private set
        {
            _balance = value;
            OnBalanceChanged(EventArgs.Empty);

            if (Math.Abs(value) >= _transactionThreshold)
            {
                OnLargeTransactionOccurred(EventArgs.Empty);
            }
        }
    }

    // Para yatırma metodu
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} Yatırıldı. Yeni Miktar: {_balance:C}");
        }
        else
        {
            Console.WriteLine("Depozito tutarı pozitif olmalıdır.");
        }
    }

    // Para çekme metodu
    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (amount <= _balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount:C} çekildi. Kalan Miktar: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }
        else
        {
            Console.WriteLine("Para çekme tutarı pozitif olmalıdır.");
        }
    }

    // Bakiye değişimi olayı tetikleme
    protected virtual void OnBalanceChanged(EventArgs e)
    {
        BalanceChanged?.Invoke(this, e);
    }

    // Büyük işlem olayı tetikleme
    protected virtual void OnLargeTransactionOccurred(EventArgs e)
    {
        LargeTransactionOccurred?.Invoke(this, e);
    }
}

// Program sınıfı
class Program
{
    static void Main(string[] args)
    {
        // Yeni hesap oluşturma
        BankAccount account = new BankAccount(1000, 500);

        // Olaylara abone olma
        account.BalanceChanged += Account_BalanceChanged;
        account.LargeTransactionOccurred += Account_LargeTransactionOccurred;

        // Hesap işlemleri
        account.Deposit(300);
        account.Withdraw(200);
        account.Deposit(700);
        account.Withdraw(1500);
    }

    // Bakiye değişimi olayını işleme
    private static void Account_BalanceChanged(object sender, EventArgs e)
    {
        BankAccount account = (BankAccount)sender;
        Console.WriteLine($"Miktar değişikliği. Halihazırda bakiye durum: {account.Balance:C}");
    }

    // Büyük işlem olayını işleme
    private static void Account_LargeTransactionOccurred(object sender, EventArgs e)
    {
        BankAccount account = (BankAccount)sender;
        Console.WriteLine($"İşlem gerçekleşti. Cari durum: {account.Balance:C}");
    }
}