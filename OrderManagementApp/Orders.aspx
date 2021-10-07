<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="WebApplication3.Orders" %>

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
                    <td>Purchase Amount</td>
                    <td><asp:TextBox ID="txtPurchAmt" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Order Date</td>
                    <td><asp:TextBox ID="OrderDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Customer ID</td>
                    <td>
                        <asp:DropDownList ID="ddlCustomerId" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Salesman ID</td>
                    <td>
                        <asp:DropDownList ID="ddlSalesmanId" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td></td><td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" Width="119px" />
                        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" /></td>
                </tr>
                <tr>
                    <td></td><td>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                             </td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="gvOrdersDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvOrdersDetails_RowCommand" OnRowDeleting="gvOrdersDetails_RowDeleting" OnRowEditing="gvOrdersDetails_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="ord_no" HeaderText="Order No." />
                        <asp:BoundField DataField="purch_amt" HeaderText="Purchase Amount" />
                        <asp:BoundField DataField="ord_date" HeaderText="Order Date" />
                        <asp:BoundField DataField="customer_id" HeaderText="CustomerID" />
                        <asp:BoundField DataField="salesman_id" HeaderText="SalesmanID" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("ord_no") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("ord_no") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
