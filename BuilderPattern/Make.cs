using BuilderPattern.Builder;

namespace BuilderPattern
{

    // This class can also be called the Director
    public class Make
    {
        private IBuilder _builder;
        public Make(IBuilder builder)
        {
            _builder = builder;
        }        

        public Person Build()
        {
            _builder.SetName();
            _builder.SetGender();
            _builder.SetAge();
            _builder.SetCircumference();
            _builder.SetWeight();
            _builder.SetHeight();
            return _builder.Build();
        }
        public void ChangeBuilder(IBuilder builder) 
        {
            _builder = builder;
        }
    }
}
