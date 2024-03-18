using DomainServices;

namespace Domain
{
    public class SprintBacklog : ISprint
    {
        private String name;
        private DateTime startDate;
        private DateTime endDate;
        private Boolean completed;
    }
}
