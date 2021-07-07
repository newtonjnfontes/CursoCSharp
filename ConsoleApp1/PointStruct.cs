
namespace ConsoleApp1 {
    //class PointStruct { -> tirada a classe para transformar em struct
    struct PointStruct {
        public double Z,X, Y;

        public override string ToString() {
            
            return "("+ Z + "." + X + "," + Y + ")";
        }
    }
}
