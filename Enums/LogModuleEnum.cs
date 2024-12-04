namespace JMWebAPI.Enums
{
    //public class LogModuleEnum
    //{
    //}

    /// <summary>
    /// Log Module Enum
    /// </summary>
    /// <author>Ray</author>
    /// <since>2.10.0</since>
    public enum LogModuleEnum
    {
        /// <summary>
        /// Login module
        /// </summary>
        Login,

        /// <summary>
        /// User module
        /// </summary>
        User,

        /// <summary>
        /// Order module
        /// </summary>
        Order,

        /// <summary>
        /// Department module
        /// </summary>
        Dept,

        /// <summary>
        /// Role module
        /// </summary>
        Role,

        /// <summary>
        /// Menu module
        /// </summary>
        Menu,

        /// <summary>
        /// Dictionary module
        /// </summary>
        Dict,

        /// <summary>
        /// Other module
        /// </summary>
        Other
    }
}

public class LogModule : IBaseEnum<string>
{
    public string Value { get; set; }
    public string Label { get; set; }

    public LogModule(string value, string label)
    {
        Value = value;
        Label = label;
    }

    public string GetValue()
    {
        return Value;
    }

    public string GetLabel()
    {
        return Label;
    }
}
