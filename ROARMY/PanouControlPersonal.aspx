<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanouControlPersonal.aspx.cs" Inherits="ROARMY.PanouControlPersonal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 355px;
        }
        .auto-style2 {
            margin-left: 78px;
            margin-right: 15px;
            margin-top: 44px;
        }
        .auto-style3 {
            margin-left: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <br />
        Autentificare reusita!&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Home</asp:LinkButton>
        <br />
        <br />
        Selectati produsele folosite azi de dumneavoastra si introduceti cantitatea folosita :&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="produse_folosite" DataTextField="Produs" DataValueField="Produs" Height="21px" Width="131px">
            <asp:ListItem Value="" Text="Select Produs" />
        </asp:DropDownList>
        <asp:SqlDataSource ID="produse_folosite" runat="server" ConnectionString="<%$ ConnectionStrings:ROARMYConnectionString %>" SelectCommand="SELECT DISTINCT [Produs] FROM [Produse]"></asp:SqlDataSource>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Introduceti cantitatea folosita:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" Height="16px" Width="131px"></asp:TextBox>
        <br />
&nbsp;
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Height="32px" OnClick="Button1_Click" Text="Actualizeaza" Width="88px" />
    
    </div>
    </form>
</body>
</html>
