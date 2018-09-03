<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_030.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Heroquest_logo.png" Width="507px" />
        <br />
        <asp:Image ID="Image2" runat="server" Height="294px" ImageUrl="~/hqcardb.jpg" Width="232px" />
&nbsp;<asp:Image ID="Image3" runat="server" Height="294px" ImageUrl="~/hqcarda.jpg" Width="232px" />
        <br />
        <asp:Button ID="battleButton" runat="server" OnClick="battleButton_Click" style="font-family: 'Comic Sans MS'" Text="Start Battle!!!" />
&nbsp;<asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" style="font-family: 'Comic Sans MS'" Text="Clear Battle" />
        <br />
    
        <asp:Label ID="resultLabel" runat="server" style="font-family: 'Comic Sans MS'"></asp:Label>
    
    </div>
    </form>
</body>
</html>
