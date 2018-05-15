<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Madlipz.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            MADLIPZ<br />
            <br />
            What is your favourite food?
            <asp:TextBox ID="food" runat="server" OnTextChanged="Food_TextBox"></asp:TextBox>
            <br />
            <br />
            What is your favourite animal?
            <asp:TextBox ID="animal" runat="server" OnTextChanged="Animal_TextBox"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Create Madlipz" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
