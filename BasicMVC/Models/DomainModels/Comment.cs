using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace BasicMVC.Models {
    
    public class Comment() {

       public int Id {get; set;}

        public DateTime CreateDate {get; set;}

        public DateTime EditDate {get; set;}

        public string CommentText {get; set;} = string.Empty;

        public string OwnerID {get; set;} = string.Empty; // represents the physical value in the DB
        public MVCUser Owner {get; set;} = null!; // Navigation property for MvcUser

        public int PostIdNumber {get; set;}

        // Navigation principle one side
        public Post Post {get; set;} = null!;
    }
} 
