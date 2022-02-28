public class Toado
{
    private float x;
    private float y;
    private string name;

    public Toado(float x, float y)
    {
        setx(x);
        sety(y);
        //setname(name);
    }
    public Toado()
    {
    }
    public void setx(float x) {this.x = x;}
    public void sety(float y) { this.y = y;}
    public void setname(string name) {this.name = name;}
    public float getX() {return x;}
    public float getY() {return y;}
    public string getName() {return name;}

    public override string ToString()
    {
        return $"{this.name} ({this.x}, {this.y})";
    }
}

