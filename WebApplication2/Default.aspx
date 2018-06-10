<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="AuthorizeButton" runat="server" Text="Авторизация через Steam" OnClick="AuthorizeButton_Click" Width="192px" />
        </div>
        <p>
            <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
