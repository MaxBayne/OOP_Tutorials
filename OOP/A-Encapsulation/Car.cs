
public class Car
{
    //Attributes ---------------
    public int Speed { get; private set; }
    public string Color { get; private set; }
    public string Model { get; private set; }

    //Constructors
    public Car() { }
    public Car(int speed, string color, string model)
    {
        Speed = speed;
        Color = color;
        Model = model;
    }




    //Actions

    #region Encapsulation


    public void ChangeSpeed(int speed)
    {
        Speed = speed;
    }
    public void ChangeColor(string color)
    {
        Color = color;
    }
    public void ChangeModel(string model)
    {
        Model = model;
    }

    #endregion

    public void TurnOn()
    {

    }

    public void TurnOff()
    {

    }
}

