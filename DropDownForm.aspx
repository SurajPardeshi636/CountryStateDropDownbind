<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownForm.aspx.cs" Inherits="DropdownBindData.DropDownForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>Country:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" >
                        <asp:ListItem Value="0">--Select Country--</asp:ListItem> 
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">state:<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                        <asp:ListItem Value="0">-- Select State--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>City:<asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="0">-- Select City--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
