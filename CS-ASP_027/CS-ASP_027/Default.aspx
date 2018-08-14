<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_027.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Heroquest_logo.png" />
        <br />
    
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
        <br />
        <asp:Image ID="resultImage" runat="server" />
        <br />
    
    </div>
    </form>
</body>
</html>
