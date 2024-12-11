
namespace BuilderPattern
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }//1:man, 0:woman
        public int ChestMeasurement { get; set; }//circumference
        public int BustMeasurement { get; set; }//circumference
        public int Height { get; set; }
        public int Weight { get; set; }
        public override string ToString()
        {
            var stringGender = Gender == 1 ? "male" : "female";
            var circumference = Gender == 1 ? "chest measurement" : "bust measurement";
            var circumferenceValue = Gender == 1 ? ChestMeasurement : BustMeasurement;
            return $"I'm {Name}, {Age} years old {stringGender}, my {circumference} " +
                $"is {circumferenceValue}cm, height is {Height}cm and weight is {Weight}kg";
        }
    }
}
