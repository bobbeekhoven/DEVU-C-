﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeCasino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Reel1" runat="server" Width="150px" />
&nbsp;<asp:Image ID="Reel2" runat="server" Width="150px" />
&nbsp;<asp:Image ID="Reel3" runat="server" Width="150px" />
            <br />
            <br />
            Your Bet:
            <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="pullButton" runat="server" OnClick="pullButton_Click" Text="Pull The Lever!" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="moneyLabel" runat="server"></asp:Label>
            <br />
            <br />
            1 Cherry - x2 Your Bet<br />
            2 Cherries - x3 Your Bet<br />
            3 Cherries - x4 Your Bet<br />
            <br />
            3 7&#39;s - Jackpot - x100 Your Bet       <br />
            HOWEVER ...<br />
            <br />
            If there&#39;s even one BAR you win nothing!</div>
    </form>
</body>
</html>
