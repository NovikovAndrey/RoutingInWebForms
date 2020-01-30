<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LocalizationSample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink 
            ID="HyperLink1" 
            runat="server"
            Text="Login ru"
            NavigateUrl =" <%$RouteUrl:lang=ru, page=login, routename=Routes %>">
            </asp:HyperLink>
            <br />
            <asp:HyperLink 
            ID="HyperLink2" 
            runat="server"
            Text="Login eu"
            NavigateUrl =" <%$RouteUrl:lang=eu, page=login, routename=Routes %>">
            </asp:HyperLink>
        </div>
    </form>
</body>
</html>
