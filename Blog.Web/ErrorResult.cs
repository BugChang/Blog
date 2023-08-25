namespace Blog.Web
{
    public class ErrorResult
    {
        public ErrorResult(int errCode, string errMsg)
        {
            ErrCode = errCode;
            ErrMsg = errMsg;
        }

        public int ErrCode { get; set; }

        public string ErrMsg { get; set; }
    }
}
