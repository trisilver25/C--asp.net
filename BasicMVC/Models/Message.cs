using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace BasicMVC.Models {

    public class Message 
    {

        public int MessageID {get; set;}
        public string MessageText {get; set;} = string.Empty;
    }
}