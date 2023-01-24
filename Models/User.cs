namespace Classes;
 public class User{
    public string name { get; }
    public string email { get; }
     public string password { get; }
    public bool gender { get;set; }
    public DateTime  birth { get; }
    public decimal height { get; }
    public int brothers { get; }
    

    public User(string name,string email, bool gender,DateTime birth, decimal height,int brothers){
        this.name=name;
        this.email=email;
        this.gender=gender;
        this.birth=birth;
        this.height=height;
        this.brothers=brothers;
    }
    public void ChangeGender(){
        gender=!gender;
    }

    public string Summary(){
        return name+" "+email+" "+gender.ToString()+" "+birth.ToString()+" "+height.ToString()+" "+ brothers.ToString();
    }
 }


 