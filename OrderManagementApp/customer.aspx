<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="WebApplication3.customer" %>

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
                    <td>Customer Name</td>
                    <td><asp:TextBox ID="CustomerName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City</td>
                    <td><asp:TextBox ID="City" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Grade</td>
                    <td><asp:TextBox ID="grade" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman ID</td>
                    <td><asp:TextBox ID="SalesmanId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td><td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"  />
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset"  /></td>
                </tr>
                <tr>
                    <td></td><td>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                             </td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="gvCustomerDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvCustomerDetails_RowCommand" OnRowDeleting="gvCustomerDetails_RowDeleting" OnRowEditing="gvCustomerDetails_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="customer_id" HeaderText="Customer ID" />
                        <asp:BoundField DataField="cust_name" HeaderText="Customer Name" />
                        <asp:BoundField DataField="city" HeaderText="City" />
                        <asp:BoundField DataField="grade" HeaderText="Grade" />
                        <asp:BoundField DataField="salesman_id" HeaderText="Salesman ID" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("customer_id") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("customer_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
