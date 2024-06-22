namespace bookingflightmvcUI.Models
{
    public class MyResponse
    {
        public Boolean error { get; set; }
        public string message { get; set; }

        public Object Object {get;set;}
        public MyResponse(Boolean error, string message, Object Object)
        {
            if (!error)
            {   
                this.error = error;
                this.message = message;
                this.Object = Object;
            }
            else
            {
                this.error = error;
                this.message = message;
            }
        }
    }
}
