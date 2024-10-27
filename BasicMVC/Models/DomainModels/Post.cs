namespace BasicMVC.Models{
    public class Post{
        public int Id {get; set;}

        public DateTime CreateDate {get; set;}

        public DateTime EditDate {get; set;}

        public string PostText {get; set;} = string.Empty;

        public string OwnerID {get; set;} = string.Empty; // represents the physical value in the DB
        public MVCUser Owner {get; set;} = null!; // Navigation property for MvcUser

        //Navigation property showing relationship by convention comments Many Side
        public ICollection<Comment> Comments {get; set;} = new HashSet<Comment>();
    }
}