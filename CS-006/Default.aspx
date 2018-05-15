<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            color: #FF0000;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            background-color: #0099FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <table class="auto-style3">
                    <tr>
                        <td>player</td>
                        <td>year</td>
                        <td>homeruns</td>
                    </tr>
                    <tr>
                        <td>Sammy Soas</td>
                        <td>2005</td>
                        <td>100</td>
                    </tr>
                    <tr>
                        <td>Mark MacGuire</td>
                        <td>2005</td>
                        <td>102</td>
                    </tr>
                </table>
                Head Line 1</h1>
            <br />
            <br />
            <h2>Head Line 2</h2>
            <br />
            <br />
            <h3>Head Line 3</h3>
            <br />
            <br />
            <h4>Head Line 4</h4>
            <br />
            <br />
            <h5>Head Line 5</h5>
            <br />
            <br />
            <h6>Head Line 6</h6>
            <p>
                &nbsp;</p>
            <p class="auto-style1">
                This is some text that I want to <span class="auto-style2">apply</span> a style to.</p>
            <p class="auto-style1">
                &nbsp;</p>
            <p class="auto-style1">
                <a href="http://www.learnvisualstudio.net">Add a hyperlink.</a></p>
            <p class="auto-style1">
                &nbsp;</p>
            <p class="auto-style1">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.microsoft.com" Target="_blank">This is another Hyperlink.</asp:HyperLink>
            </p>
            <p class="auto-style1">
                &nbsp;</p>
            <p class="auto-style1">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/cs-006.png" />
            </p>
            <p class="auto-style1">
                &nbsp;</p>
            <ol>
                <li>
                    <p class="auto-style1">
                        First Item</p>
                </li>
                <li>
                    <p class="auto-style1">
                        Second Item</p>
                </li>
                <li>
                    <p class="auto-style1">
                        Third Item</p>
                </li>
            </ol>
            <p class="auto-style1">
                &nbsp;</p>
            <ul>
                <li>
                    <p class="auto-style4">
                        This is an idea.</p>
                </li>
                <li>
                    <p class="auto-style4">
                        This nis an equally good idea.</p>
                </li>
                <li>
                    <p class="auto-style4">
                        Yet one more idea to consider.</p>
                </li>
            </ul>
            <p class="auto-style1">
                &nbsp;</p>
        </div>
    </form>
</body>
</html>
