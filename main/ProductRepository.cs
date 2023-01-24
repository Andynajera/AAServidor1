namespace Classes;

class ProductRepository{
    List<Product> data = new List<Product>();

    public void create(Product newProduct){
        data.Add(newProduct);
    }

    public List<Product> all(){
        return data;
    }

    public Product find(string name){
        return data.Find(item=> item.name== name);
    }

}
