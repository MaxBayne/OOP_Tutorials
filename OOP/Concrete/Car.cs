namespace OOP.Models
{
    public class Car
    {
        //Attributes ---------------
        private int _speed;
        private string _color;
        private string _model;

        //Constructors
        public Car()
        {
            
        }
        public Car(int speed , string color,string model)
        {
            this._speed = speed;
            this._color = color;
            this._model = model;
        }


        //Actions
        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }
    }
}
