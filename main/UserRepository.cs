namespace Classes;
using System.Text;
using System.Text.Json;
class UserRepository{
    List<User> data = new List<User>();

    public void create(User newUser){
        data.Add(newUser);
    }

    public List<User> all(){
        return data;
    }

    public User find(string name){
        return data.Find(item=> item.name== name);
    }


}
