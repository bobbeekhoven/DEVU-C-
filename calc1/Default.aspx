<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="calc1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculater</h1>
            <p>
                <span class="auto-style1">value 1</span>:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                <span class="auto-style1">value 2</span>:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;<asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" />
&nbsp;<asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" />
&nbsp;<asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server" style="background-color: #00CCFF"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
