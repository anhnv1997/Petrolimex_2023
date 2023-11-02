namespace iPGSTools.Models
{
    public class ResponseModel<T> where T : class
    {
        public string code { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }
}
