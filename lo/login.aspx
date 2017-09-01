<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="lo.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Namelbl" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nametxt" runat="server"  style="margin-left: 232px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="passwordlbl" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passwordtxt" runat="server" style="margin-left: 208px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="loginbtn" runat="server"  style="margin-left: 213px" Text="Login" OnClick="loginbtn_Click1" />
        <asp:Button ID="Registerbtn" runat="server"  style="margin-left: 213px" Text="Register" OnClick="Registerbtn_Click" />
    <div>
    
        this is changed page</div>
    </form>
</body>
</html>
