namespace ClassLibrary13feb
{
    public class Login
    {
        public string LoginDetails(string username, string password)
        {
            string result = "";
            if (username == "Moses" && password == "1234")
            {
                result = "Login Successfull";
            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }
    }
}
