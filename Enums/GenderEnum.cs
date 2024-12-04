namespace JMWebAPI.Enums
{
    public class Gender : IBaseEnum<int>
    {
        public int Value { get; set; }
        public string Label { get; set; }

        public Gender(int value, string label)
        {
            Value = value;
            Label = label;
        }

        public int GetValue()
        {
            return Value;
        }

        public string GetLabel()
        {
            return Label;
        }
    }

}
