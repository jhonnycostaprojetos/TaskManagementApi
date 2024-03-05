namespace TaskManagement.Domain.Entities
{
    public sealed class Comment : BaseEntity
    {
        public string TaskComment { get; private set; }

        public int IdTaskProject { get; private set; }

        public TaskProject TaskProject { get; private set; }

        public Comment()
        {
            
        }

        public Comment(int id, string taskcomment, int idTaskProject )
        {
            Id = id;
            IdTaskProject = idTaskProject;
            TaskComment = taskcomment;            
            
        }
    }
}
