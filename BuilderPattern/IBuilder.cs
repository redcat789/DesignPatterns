namespace BuilderPattern
{
    public interface IBuilder
    {
        void SetName();
        void SetAge();
        void SetGender();
        void SetCircumference();
        void SetWeight();
        void SetHeight();
        Person Build();
    }
}
