<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="font-family: Arial, Helvetica, sans-serif">
                <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" Width="150px" />
                <br />
                <br />
                Asset Performance Tracker</h1>
            <p>
                Asset Name:
                <asp:TextBox ID="assetTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                Elections Rigged:
                <asp:TextBox ID="electionTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                Acts of Subterfuge Performed:
                <asp:TextBox ID="actsTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
