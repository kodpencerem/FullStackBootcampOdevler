namespace Odev1;

public abstract class Vehicle
{
    public abstract void Operate();
}

public class Car : Vehicle
{
    public override void Operate()
    {
        Drive();
    }

    private void Drive()
    {
    }
}

public class Bicycle : Vehicle
{
    public override void Operate()
    {
        Pedal();
    }

    private void Pedal()
    {
    }
}

// Usage
public class VehicleOperator
{
    public void OperateVehicle(Vehicle vehicle)
    {
        vehicle.Operate();
    }
}

