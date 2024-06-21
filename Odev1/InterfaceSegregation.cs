namespace Odev1;

public interface IMachine
{
    void Print();
    void Scan();
    void Fax();
}

public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public interface IFax
{
    void Fax();
}

public class MultiFunctionPrinter : IPrinter, IScanner, IFax
{
    public void Print() {  }
    public void Scan() {  }
    public void Fax() {  }
}

public class SimplePrinter : IPrinter
{
    public void Print() {  }
}
