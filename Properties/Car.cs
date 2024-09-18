class Car
{
    private string _model;
    public string Model 
    {
        get { return _model; }
        set { _model = value; } 
    }
    private int _price;
    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }
    private string _color;
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
    public Car()
    {
        
    }
    public Car(string model, int price, string color)
    {
        _model = model;
        _price = price;
        _color = color;
    }
    public void HalfPrice()
    {
        this.Price = _price / 2;
    }
}