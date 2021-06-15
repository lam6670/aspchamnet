﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TienLuong.aspx.cs" Inherits="Vidu2_response.TienLuong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 41%;
        }
        .auto-style2 {
            width: 733px;
        }
        .auto-style3 {
            width: 606px;
        }
        .auto-style4 {
            width: 606px;
            height: 26px;
        }
        .auto-style5 {
            width: 733px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Mã NV"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server" Width="243px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Bậc lương"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="243px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Ngày công:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server" Width="243px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Chức vụ"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
               
               
                <tr align ="center">
                    <td class="auto-style3" colspan ="2">
                        <asp:Button ID="Button1" runat="server" Text="Tính"  PostBackUrl="~/TinhTienLuong.aspx"/>
                        <asp:Button ID="Button2" runat="server" Text="Xóa" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
