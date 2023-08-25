namespace Blog.Application.DTOs
{
    public class ErrorDto
    {
        public ErrorDto(int errCode, string errMsg)
        {
            ErrCode = errCode;
            ErrMsg = errMsg;
        }

        public int ErrCode { get; set; }

        public string ErrMsg { get; set; }
    }
}
