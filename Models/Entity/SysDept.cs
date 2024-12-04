namespace JMWebAPI.Models.Entity
{
    public class SysDept
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long ParentId { get; set; }
        public string TreePath { get; set; }
        public int Sort { get; set; }
        public int Status { get; set; }
        public long CreateBy { get; set; }
        public long UpdateBy { get; set; }
    }
}
