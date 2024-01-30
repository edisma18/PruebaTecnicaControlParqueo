<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultMain.aspx.cs" Inherits="Solution.UI.Web._DefaultMain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="Sistema de Control de Parqueo">
        <h3>Menú Principal</h3>
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilterName" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <asp:Button ID="btnFilter" runat="server" onclick="btnFilter_Click" 
                Text="Filtrar" />
            <br />
        
            <table class="style1">
    <tr>
        <td></td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td></td>
        <td>
            
            
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="btnEnviar" runat="server" Text="Registrar Carro" Width="118px"
                OnClick="btnEnviar_Click" />
         <td>
            &nbsp;</td>
        <td>
            
            <asp:Button ID="btnEntrada" runat="server" Text="Registra Entrada"
                OnClick="Button1_Click" />  <asp:Button ID="btnSalida" runat="server"
                Text="Registra Salida" OnClick="btnSalida_Click" />

             <td>
    &nbsp;</td>
<td>
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
