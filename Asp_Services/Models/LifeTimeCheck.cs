namespace Asp_Services.Models
{
    
        public interface STLifeTimeCheck
        {
            Guid id { get; }
        }
        public interface SCLifeTimeCheck
        {
            Guid id { get; }
        }
        public interface TRLifeTimeCheck
        {
            Guid id { get; }
        }
    public class LifeTimeCheck_1 : STLifeTimeCheck
    {
        public Guid id {  get; } = Guid.NewGuid();
    }

    public class LifeTimeCheck_2 : SCLifeTimeCheck
    {
        public Guid id { get; } = Guid.NewGuid();
    }

    public class LifeTimeCheck_3 : TRLifeTimeCheck
    {
        public Guid id { get; } = Guid.NewGuid();
    }

}
