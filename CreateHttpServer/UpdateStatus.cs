namespace CreateHttpServer
{
    class UpdateStatus : IStatus
    {
        public UpdateStatus(string message)
        {
            Message = message;
        }

        public string Message{ get; }    
    }
}
