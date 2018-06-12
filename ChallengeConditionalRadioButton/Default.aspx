<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your note taking preferences<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" Text="Pencil" GroupName="preference" />
            <br />
            <asp:RadioButton ID="penRadioButton" runat="server" Text="Pen" GroupName="preference" />
            <br />
            <asp:RadioButton ID="phoneRadioButton" runat="server" Text="Phone" GroupName="preference" />
            <br />
            <asp:RadioButton ID="tabletRadioButton" runat="server" Text="Tablet" GroupName="preference" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" Text="OK" OnClick="okButton_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Image ID="resultImage" runat="server" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
