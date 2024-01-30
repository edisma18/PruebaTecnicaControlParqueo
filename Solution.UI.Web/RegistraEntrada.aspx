<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistraEntrada.aspx.cs" Inherits="Solution.UI.Web.RegistraEntrada" %>

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
    <script type="text/Javascript" language ="javascript" >  
        function showAlert() {
            alert("El vehículo ya se encuentra dentro del parqueo!");
        }

        function sumValues(a, b) {
            var c = a + b;
            alert("Sum of provided values is " + c);
        }

        function displayMessage(msg) {
            alert("La placa del carro es: " + msg);
        }
    </script>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="Registrar Entrada de Vehículos">
            <table class="style1">
                <tr>
                    <td>
                        Placa                    
                        <asp:TextBox ID="txtPlaca" runat="server" Width="180px" MaxLength="39"></asp:TextBox> 
                     </td>
                     <td>
                         Hora Actual:  <asp:TextBox runat="server" ReadOnly="True" ID="txtTime"></asp:TextBox>
                    </td>
                </tr>
                <tr> 
                </tr>
                <tr>
                    <td>
                    
                        &nbsp; <asp:Button runat="server" Text="Validar Vehículo" OnClick="Unnamed1_Click"></asp:Button>
                        <asp:Button ID="btnEnviar" runat="server" Text="Registrar Entrada" Width="128px" OnClick="btnEnviar_Click" /><asp:Button ID="btnBack" runat="server" onclick="btnBack_Click" 
                            Text="Regresar" /> <asp:RadioButtonList runat="server" ID="optResident">
                            <asp:ListItem>Es Residente</asp:ListItem>
                            <asp:ListItem>Es Oficial</asp:ListItem>
                            <asp:ListItem>Es Visitante</asp:ListItem>
                        </asp:RadioButtonList> </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                        
                        <asp:Label runat="server" ID="lblName"></asp:Label>       </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
