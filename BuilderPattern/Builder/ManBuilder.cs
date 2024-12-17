namespace BuilderPattern.Builder
{

    public class ManBuilder : IBuilder
    {
        private Person _man;
        public ManBuilder()
        {
            _man = new Person();
        }
        public void SetName()
        {
            _man.Name = "Josh";
        }
        public void SetGender()
        {
            _man.Gender = 1;
        }
        public void SetAge()
        {
            _man.Age = 24;
        }

        public void SetCircumference()
        {
            _man.ChestMeasurement = 89;
        }

        public void SetWeight()
        {
            _man.Weight = 86;
        }

        public void SetHeight()
        {
            _man.Height = 188;
        }
        public Person Build()
        {
            return _man;
        }
    }
}
