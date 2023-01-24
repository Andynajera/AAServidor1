namespace Classes;

class ProductRepository{
    List<Grades> data = new List<Grades>();

    public void create(Grades newProduct){
        data.Add(newProduct);
    }

    public List<Grades> all(){
        return data;
    }

    public Grades find(string name){
        return data.Find(item=> item.name== name);
    }

}
