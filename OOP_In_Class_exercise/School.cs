using OOP_Introduction;
namespace OOP_Introduction{
    public class School{
        string name;
        string pricipal;
        int studentCount; 
    
        public School(){
            name = "";
            pricipal = "";
            studentCount = 0;
        }
        public School(string name,string pricipal){
            this.name = name;
            this.pricipal = pricipal;
        }
    }
}
