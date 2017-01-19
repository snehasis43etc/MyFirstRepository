<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebApplication1.Log_In" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script type="text/javascript">
    window.history.forward();
    function noBack() {
        window.history.forward();
    }
</script>
<body  onload="noBack();">
    <form id="form1" runat="server">
    <div>
     <br />
        Username<br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Password<br />
        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        <br />
         Remember me?
        
          <asp:CheckBox ID="Persist" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Label ID="Msg" runat="server" Text="Label"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
