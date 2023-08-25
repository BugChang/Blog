namespace Blog.Domain
{
    public class BusinessException : Exception
    {
        public ErrorCode ErrCode { get; set; }

        public string ErrMsg { get; set; }

        public BusinessException(ErrorCode errCode, string errMsg)
        {
            ErrCode = errCode;
            ErrMsg = errMsg;
        }
    }

    public enum ErrorCode
    {
        OperationFail = 1,
        ValidateFail = 2,
    }
}
