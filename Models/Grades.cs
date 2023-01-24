namespace Classes;
 public class Grades{
    public string name { get; }
    public string nameDegree { get; }
    public bool quedanPlazas { get;set; }
    public DateTime  dataExpediente { get; }
    public decimal price { get; }
    public int cantidadPlazas { get; }
    

    public Grades(string name,string nameDegree, bool quedanPlazas,DateTime dataExpediente, decimal price,int cantidadPlazas){
        this.name=name;
        this.nameDegree=nameDegree;
        this.quedanPlazas=quedanPlazas;
        this.dataExpediente=dataExpediente;
        this.price=price;
        this.cantidadPlazas=cantidadPlazas;
    }
    public void ChangeGender(){
        quedanPlazas=!quedanPlazas;
    }

    public string Summary(){
        return name+" "+nameDegree+" "+quedanPlazas.ToString()+" "+dataExpediente.ToString()+" "+price.ToString()+" "+ cantidadPlazas.ToString();
    }
 }


 