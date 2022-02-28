public class Hinhtron {
    private Toado Tam;
    private double Bankinh;


    public double TinhChuVi(){
        return 2*Bankinh*3.14;
    }
    public double TinhDienTich(){
        return Bankinh*Bankinh*3.14;
    }
    public Hinhtron(){

    }
    public Hinhtron(Toado tam ,double Bankinh){
        this.Bankinh = Bankinh;
        this.Tam= tam;
    }
    public double getBankinh() {return Bankinh;}
    public Toado getTam() {return Tam;}
    public void setTam(Toado tam){
        this.Tam = (Toado)tam;
    }
    public void setBanKinh(double Bankinh){
        this.Bankinh = Bankinh;
    }
    public override string ToString()
    {
        string toado = Tam.getX().ToString() +"," +Tam.getY().ToString();
        return toado;
    }
}