
namespace Password.Validation
{
    public class Password
    {
        public string Pwd { get; set; }
        public int Length { get; set; }

        public Password()
        {
            Pwd = string.Empty;
            Length = 0;
        }

        public Password(string pwd)
        {
            Pwd = pwd;
            Length = pwd.Length;
        }
    }
}