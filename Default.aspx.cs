using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Imaging;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnscreenshot_click(object sender, EventArgs e)
    {
        //Thread thread = new Thread(GenerateThumbnail);
        //thread.SetApartmentState(ApartmentState.STA);
        //thread.Start();
        //thread.Join();
        
        Bitmap bitmap = new Bitmap(Convert.ToInt32(Session["BrowserWidth"]), Convert.ToInt32(Session["BrowserHeight"]));
        Graphics graphics = Graphics.FromImage(bitmap as System.Drawing.Image);

        graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
        MemoryStream stream = new MemoryStream();
        bitmap.Save(@"D:\myscreenshot.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        bitmap.Save(stream, ImageFormat.Jpeg);
        byte[] strbytes = stream.ToArray();

        imgscreenshot.Visible = true;
        // imgscreenshot.Width = webrowse.Width;
        // imgscreenshot.Height = webrowse.Height;

        imgscreenshot.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String(strbytes);
    }
    private void GenerateThumbnail()
    {
        WebBrowser webrowse = new WebBrowser();
        webrowse.ScrollBarsEnabled = true;
        webrowse.AllowNavigation = true;
        String urls = Request.Url.ToString();
       // webrowse.Navigate(txtweburl.Text.Trim());
        //webrowse.Width = Convert.ToInt32(Session["BrowserWidth"]);
        //webrowse.Height = Convert.ToInt32(Session["BrowserHeight"]);
        webrowse.DocumentCompleted += webbrowse_DocumentCompleted;
        
        while (webrowse.ReadyState != WebBrowserReadyState.Complete)
        {
            System.Windows.Forms.Application.DoEvents();
        }
    }
    private void webbrowse_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
        //WebBrowser webrowse = sender as WebBrowser;
        //Bitmap bitmap = new Bitmap(webrowse.Width, webrowse.Height);
        //webrowse.DrawToBitmap(bitmap, webrowse.Bounds);
        //MemoryStream stream = new MemoryStream();
        //bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
        //bitmap.Save(@"D:\myscreenshot.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        //byte[] strbytes = stream.ToArray();

        Bitmap bitmap = new Bitmap(Convert.ToInt32(Session["BrowserWidth"]), Convert.ToInt32(Session["BrowserHeight"]));
        Graphics graphics = Graphics.FromImage(bitmap as System.Drawing.Image);

        graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
        MemoryStream stream = new MemoryStream();
        bitmap.Save(@"D:\myscreenshot.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        bitmap.Save(stream, ImageFormat.Jpeg);
        byte[] strbytes = stream.ToArray();

        imgscreenshot.Visible = true;
       // imgscreenshot.Width = webrowse.Width;
       // imgscreenshot.Height = webrowse.Height;

        imgscreenshot.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String(strbytes);
    }
}