<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF6600;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Image ID="Image1" runat="server" CssClass="auto-style2" ImageUrl="~/PapaBob.png" />
                <span class="auto-style2">Papa Bob&#39;s Pizza and Software</span></h1>
        </div>
        <asp:RadioButton ID="babyButton" runat="server" GroupName="pizza" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="mamaButton" runat="server" GroupName="pizza" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="papaButton" runat="server" GroupName="pizza" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="thinButton" runat="server" GroupName="bottom" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepButton" runat="server" GroupName="bottom" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenPeppersCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redPeppersCheckBox" runat="server" Text="Red Peppers ($0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies ($2)" />
        <br />
        <h2><span class="auto-style2">Papa Bob&#39;s </span><span class="auto-style1">Special Deal</span></h2>
        <p>
            Save $2,00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza</p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Purchase" />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Clear Form" />
        </p>
        <p>
            Total: <asp:Label ID="resultLabel" runat="server" Text="$0,00"></asp:Label>
        </p>
        <p>
            Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better website!</p>
    </form>
</body>
</html>
