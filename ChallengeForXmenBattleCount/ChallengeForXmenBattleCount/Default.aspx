<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeForXmenBattleCount.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Comic Sans MS";
            text-decoration: underline;
            font-weight: normal;
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 932px; background-color: #FFFF00">
    
        <asp:Image ID="Image1" runat="server" Height="121px" ImageUrl="~/kisspng-professor-x-cyclops-wolverine-x-men-logo-x-men-5ac42d4b9cfbf0.434739291522806091643.jpg" Width="244px" />
        <h4 class="auto-style1"><em><strong>X-MEN BATTLE COUNTER</strong></em></h4>
    
        <asp:Label ID="resultLabel" runat="server" style="font-family: 'Comic Sans MS'; color: #FF0000; font-weight: 700; font-style: italic; text-decoration: underline"></asp:Label>
    
    </div>
    </form>
</body>
</html>
