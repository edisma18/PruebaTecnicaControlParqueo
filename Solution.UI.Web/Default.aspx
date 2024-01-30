<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Solution.UI.Web._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="Cliente">
        <h3>Listado de clientes</h3>
        <br />
            <asp:GridView ID="grdCustomers" runat="server" CellPadding="4" 
                DataKeyNames="Id" GridLines="None" onrowcommand="grdCustomers_RowCommand" 
                ForeColor="#333333" OnSelectedIndexChanged="grdCustomers_SelectedIndexChanged" 
                Width="835px" AllowPaging="True" AllowSorting="True" 
                onpageindexchanging="grdCustomers_PageIndexChanging" 
                onrowdeleted="grdCustomers_RowDeleted" 
                onrowdatabound="grdCustomers_RowDataBound" 
                onrowdeleting="grdCustomers_RowDeleting">
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <Columns>
                    <asp:ButtonField CommandName="edit" Text="Editar"  />
                    <asp:TemplateField HeaderText="Select">
                     <ItemTemplate>
                       <asp:LinkButton ID="LinkButton1" 
                         CommandArgument='<%# Eval("Id") %>' 
                         CommandName="Delete" runat="server">
                         Delete</asp:LinkButton>
                     </ItemTemplate>
                   </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#999999" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" Text="Crear Cliente" 
                onclick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilterName" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <asp:Button ID="btnFilter" runat="server" onclick="btnFilter_Click" 
                Text="Filtrar" />
            <br />
        
        
        </asp:Panel>
    
    </div>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
