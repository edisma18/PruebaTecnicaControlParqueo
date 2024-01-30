<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCustomers.aspx.cs" Inherits="Solution.UI.Web.UpdateCustomers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="Clientes">
            <table class="style1">
                <tr>
                    <td>
                        Nombre</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="180px" MaxLength="39"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Categoria</td>
                    <td>
                        <asp:DropDownList ID="ddlCategories" runat="server" DataTextField="Name" 
                            DataValueField="Id">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" Width="68px" 
                            onclick="btnEnviar_Click" />
                        &nbsp;<asp:Button ID="btnBack" runat="server" onclick="btnBack_Click" 
                            Text="Regresar" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
