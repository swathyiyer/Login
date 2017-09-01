<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="lo.Reg.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="idlbl2" runat="server" Text="id"></asp:Label>
        <asp:TextBox ID="idtxt1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="namelbl1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nametxt1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="passwordlbl1" runat="server" Text="password"></asp:Label>
        <asp:TextBox ID="passwordtxt1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="submit" />
    <div>
    
    </div>
    </form>
</body>
</html>
