using OOP_Introduction;
namespace OOP_Introduction{
    public class MiddleSchool : School{
        int lowestGrade;
        int highestGrade;
        public MiddleSchool() :base(){
            lowestGrade = 6;
            highestGrade = 9;
        }
        public MiddleSchool(int lowestGrade, int highestGrade) : base(){
            this.lowestGrade=lowestGrade;
            this.highestGrade=highestGrade;
        }
        public MiddleSchool(string name, string pricipal, int lowestGrade, int highestGrade) : base(name, pricipal){
            this.lowestGrade= lowestGrade; 
            this.highestGrade = highestGrade;
        }
    }
}