namespace iPGSTools.Models
{
    public class MessageModel
    {
        private int code = 0;

        private string message = "";

        private BodyModel Body = null;

        public int Code { get => code; set => code = value; }
        public string Message { get => message; set => message = value; }
        public BodyModel body { get => Body; set => Body = value; }


        public MessageModel MessageSuccess()
        {
            BodyModel bodyModel = new BodyModel();
            bodyModel.Mess = "";

            MessageModel model = new MessageModel()
            {
                Code = 200,
                Message = "Success",
                Body = bodyModel,
            };
            return model;
        }
        public MessageModel MessageFail()
        {
            BodyModel bodyModel = new BodyModel();
            bodyModel.Mess = "";

            MessageModel model = new MessageModel()
            {
                Code = 1,
                Message = "Fail",
                Body = bodyModel,
            };
            return model;
        }
    }
}
