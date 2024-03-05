namespace TaskManagement.Domain.Entities
{
    public sealed class Comment : BaseEntity
    {
        public string TaskComment { get; private set; }

        public int TaskProjectId { get; private set; }
        public TaskProject TaskProject { get; private set; }

        public int IdUser {  get; private set; }
        public IEnumerable<User> User { get; private set; }


        public Comment()
        {
            
        }

        public Comment(int id, string taskcomment, int taskProjectId)
        {
            Id = id;
            TaskProjectId = taskProjectId;
            TaskComment = taskcomment;     
        }
    }
}
