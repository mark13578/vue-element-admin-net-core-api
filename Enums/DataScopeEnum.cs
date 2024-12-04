namespace JMWebAPI.Enums
{
    public enum DataScopeEnum
    {
        /// <summary>
        /// All data
        /// </summary>
        All = 0,

        /// <summary>
        /// Department and sub-department data
        /// </summary>
        DeptAndSub = 1,

        /// <summary>
        /// Department data
        /// </summary>
        Dept = 2,

        /// <summary>
        /// Personal data
        /// </summary>
        Self = 3
    }
}

public interface IBaseEnum<T>
{
    T GetValue();
    string GetLabel();
}

public class DataScope : IBaseEnum<int>
{
    public int Value { get; set; }
    public string Label { get; set; }

    public DataScope(int value, string label)
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
