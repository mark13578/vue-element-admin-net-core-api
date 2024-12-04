namespace JMWebAPI.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IPage<T>
    {
        List<OrderItem> Orders { get; }

        bool OptimizeCountSql => true;

        bool OptimizeJoinOfCountSql => true;

        bool SearchCount => true;

        long Offset => Current <= 1 ? 0 : Math.Max((Current - 1) * Size, 0);

        long? MaxLimit => null;

        long Pages => Size == 0 ? 0 : (Total / Size) + (Total % Size != 0 ? 1 : 0);

        List<T> Records { get; set; }

        long Total { get; set; }

        long Size { get; set; }

        long Current { get; set; }

        IPage<R> Convert<R>(Func<T, R> mapper)
        {
            var mappedRecords = Records.Select(mapper).ToList();
            return new Page<R>(mappedRecords, Total, Size, Current);
        }

        string CountId => null;
    }

    public class OrderItem
    {
        // Add properties and methods for OrderItem as needed
    }

    public class Page<T> : IPage<T>
    {
        public Page(List<T> records, long total, long size, long current)
        {
            Records = records;
            Total = total;
            Size = size;
            Current = current;
        }

        public List<OrderItem> Orders { get; private set; } = new List<OrderItem>();

        public List<T> Records { get; set; }

        public long Total { get; set; }

        public long Size { get; set; }

        public long Current { get; set; }
    }

}
