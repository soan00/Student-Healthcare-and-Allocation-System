<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="health.aspx.cs" Inherits="parentComp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
    
        <asp:Label ID="Label1" runat="server" Text="Student Health Details" Font-Bold="True" Font-Size="X-Large" style="text-align:center" ></asp:Label>
    
    </div><br />
        <asp:TextBox ID="TextBox1" runat="server" Width="501px" OnTextChanged="TextBox1_TextChanged" style="margin-bottom: 0px" ToolTip="Enter Name" Height="30px" ></asp:TextBox>
       &nbsp; <asp:Button ID="Search" runat="server" Height="30px" Text="Search" OnClick="Search_Click" />
        <br /><br />
        <asp:GridView ID="GridView1" runat="server" style="text-align:center">
        </asp:GridView>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Give Feedback!" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
