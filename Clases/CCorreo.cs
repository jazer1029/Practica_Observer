using System.Net;
using System.Net.Mail;

class CCorreo 
{
    public string? sendMail (string to, string asunto, string body) 
    {
        string? msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde";
        string? from = "dasmel0229@outlook.com";
        string? displayname = "Carlos Daniel";

        try
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from, displayname);
            
            mail.To.Add(to );

            mail.Subject = asunto;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.Credentials = new NetworkCredential(from, "Luinyvel#26");
            client.EnableSsl = true;

            client.Send(mail);
            msge = "¡Correo Enviado Correctamente! ¡Pronto te contactaremos!";

        }
        catch (Exception ex)
        {
            msge = ex.Message + ". Por Favor verifica tu conexion a internet y que tus datos sean correctos e intente nuevamente."; 
        }

        return msge;
    }
}

