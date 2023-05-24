using System.Text;

namespace EPS.Smartcart.Application.Utils;

public class CodeUtil
{
    public static string Generate(int length)
    {
        Random random = new Random();
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder codeBuilder = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            int randomIndex = random.Next(chars.Length);
            codeBuilder.Append(chars[randomIndex]);
        }

        return codeBuilder.ToString();
    }
}