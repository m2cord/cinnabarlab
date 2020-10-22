using System.Text.Encodings.Web;

public class LoginResultModel {
    private string _username;
    public bool Success { get; set; }
    public string Username {
        get
        {
            return HtmlEncoder.Default.Encode(_username);
        }
        set
        {
            _username = value;
        }
    }
}