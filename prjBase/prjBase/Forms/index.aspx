<%@  Page Language="C#" Title="Cripto" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="prjBase.Forms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Criptografia Simétrica</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:700px; 
                    text-align:center; 
                    font-size:larger; 
                    font-family:Verdana;">
                <tr>
                    <td colspan="2" >
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" >
                        <asp:Label ID="lbTitulo" runat="server"/> 
                    </td>
                </tr>
                 <tr>
                    <td colspan="2" >
                        <hr />
                    </td>
                </tr>
                 <tr>
                    <td colspan="2">
                        <asp:Label ID="lbArquivo" runat="server"/> 
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                     <input id="arquivo" 
                         type="file" 
                         name="arquivo" 
                         runat="server" 
                         style="width:500px;" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                         <asp:Label ID="lbNomeArquivoSaida" runat="server"/> 
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="txNomeArquivoSaida" runat="server" Width="500px"/> 
                    </td>
                </tr>
                 <tr>
                    <td colspan="2" >
                        <hr />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Button ID="btCrip" runat="server" Text="Crip" Width="90px" OnClick="btCrip_Click"/>
                    </td>
                     <td>
                       <asp:Button ID="btDecrip" runat="server" Text="Decrip" Width="90px" OnClick="btDecrip_Click" />
                    </td>
                </tr>
                 <tr>
                    <td colspan="2" >
                        <hr />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
