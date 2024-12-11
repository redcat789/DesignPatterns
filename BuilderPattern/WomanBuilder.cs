namespace BuilderPattern
{
    public class WomanBuilder : IBuilder
    {
        private Person _woman;
        public WomanBuilder()
        {
            _woman= new Person();
        }
        public void SetName()
        {
            _woman.Name = "Lisa";
        }
        public void SetGender()
        {
            _woman.Gender=0;
        }
        public void SetAge()
        {
            _woman.Age = 18;
        }

        public void SetCircumference()
        {
            _woman.BustMeasurement = 87; 
        }

        public void SetWeight()
        {
            _woman.Weight = 57;
        }

        public void SetHeight()
        {
            _woman.Height = 175;
        }
        public Person Build()
        {
            return _woman;
        }        
    }
}
