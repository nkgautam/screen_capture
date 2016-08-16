<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/BrowserWindowSize.js"></script>
    <script type = "text/javascript">
        function GetTextboxCordinates() {
            var txt = document.getElementById("btnscreenshot");
            var p = GetScreenCordinates(txt);
            $('#<%= ScreenCordinates.ClientID %>').val(p);
        }
    </script>

<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField ID="ScreenCordinates" runat="server" />
        <table>
        <%--<tr>
        <td><b>Enter Web Url:</b></td>
        <td><asp:TextBox ID="txtweburl" runat="server" /></td>
        </tr>--%>
        <tr>
        <td></td>
        <td>
        <asp:Button ID="btnscreenshot" Text="Take Screenshot" runat="server" OnClick="btnscreenshot_click" />
        </td>
        </tr>
        </table>
        <br />
        <asp:Image ID="imgscreenshot" runat="server" Visible = "false"  />
        <h3>
            herer eh <br />
            rerwer<br />
            sfdsfs<br />
            fs<br />
            fs<br />
            fsf<br />
            sf<br />
            sf<br />
            sfs<br />
            fs<br />
            fs<br />
            fs<br />
            fs<br />
            f<br />
            sf<br />
            sf<br />
            sf<br />
            sf<br />
            sf<br />
            sf<br />
            sf<br />
            s<br />
            fs<br />
            fs<br />
            fs<br />
            fs<br />
            f<br />
            sfv
            sf<br />
            sf<br />
            sf<br /><br />
            sf<br />
            <br />
            fs
            fs<br />v
            f<br />
            sf<br />
            s<br />
            fs<br />
            f<br />
            sf<br />
            sf<br />
            s<br />
            f<br />
            sfs<br />
            f<br />
            sf<br />
            sf<br />
            sf<br />
            sf<br />
            s<br />
            ffsdsfs<br />fsf
            sv<br />
            end<br />
        </h3>
    </div>
    </form>
</body>
</html>
