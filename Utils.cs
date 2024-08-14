namespace AimoTools.Utils
{
    public class Utils
    {
        public string GetRandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                               .Select(s => s[random.Next(s.Length)]).ToArray()); 
        }        
    }
}
