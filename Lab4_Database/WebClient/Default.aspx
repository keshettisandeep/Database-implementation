<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 287px">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <p style="height: 43px; width: 492px; margin-left: 440px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Arithmatic Operations</strong>&nbsp;</p>
    <p style="height: 34px; width: 489px; margin-left: 440px">
&nbsp;&nbsp; Value1&nbsp;
        <asp:TextBox ID="TextBox1" 
            runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Value 2&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" ontextchanged="TextBox2_TextChanged" 
            style="margin-left: 0px" Width="111px"></asp:TextBox>
    </p>
    <p style="height: 165px; width: 585px; margin-left: 440px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Add" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Subtract" 
            onclick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Multiply" 
            onclick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Division" 
            onclick="Button4_Click" /><br /><br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;The 
        Result is&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p style="height: 165px; width: 315px; margin-left: 440px">
        &nbsp;</p>
    <p style="height: 165px; width: 315px; margin-left: 440px">
        &nbsp;</p>
    <p style="height: 165px; width: 315px; margin-left: 440px">
        &nbsp;</p>
    </form>
</body>
</html>
