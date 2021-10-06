<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Salesman name</td><td>
                        <asp:TextBox ID="txtSalesmanname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman city</td><td>
                        <asp:TextBox ID="txtSalesmancity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman commission</td><td>
                        <asp:TextBox ID="txtSalesmancommision" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td><td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                             </td>
                </tr>
                <tr>
                    <td></td><td>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                             </td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="gvSalesmanDetails" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvSalesmanDetails_RowDeleting" OnRowEditing="gvSalesmanDetails_RowEditing" OnRowCommand="gvSalesmanDetails_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="salesman_id" HeaderText="Salesman ID" />
                        <asp:BoundField DataField="name" HeaderText="Salesman Name" />
                        <asp:BoundField DataField="city" HeaderText="City" />
                        <asp:BoundField DataField="commission" HeaderText="Commission" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("salesman_id") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("salesman_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
