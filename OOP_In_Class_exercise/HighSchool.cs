using OOP_Introduction;
namespace OOP_Introduction{
    public class HighSchool : School{
        string SportFieldName; 

        public HighSchool() : base() {SportFieldName = "";}
        public HighSchool(string SportFieldName) : base() { SportFieldName = SportFieldName;}
        public HighSchool(string SportFieldName, string name, string principal) : base(name, principal) { SportFieldName = SportFieldName;}

    }
}