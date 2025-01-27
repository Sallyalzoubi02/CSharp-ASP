<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editbook.aspx.cs" Inherits="TASK1.editbook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">bookname</th>
                        <th scope="col">type</th>
                        <th scope="col">level</th>
                    </tr>
                </thead>
                <tbody id="TableBody" runat="server">
                </tbody>
            </table>


            <div class="container bg-primary d-flex flex-column align-items-center justify-content-center w-50 mt-5 p-5">
                <label>book id:</label>
                <asp:TextBox ID="bookId" runat="server"></asp:TextBox>
                <br />
                <br />
                <label>book name:</label>
                <asp:TextBox ID="bookName" runat="server"></asp:TextBox>
                <br />
                <br />
                <label>book type:</label>
                <asp:TextBox ID="bookType" runat="server"></asp:TextBox>
                <br />
                <br />
                <label>book level:</label>
                <asp:TextBox ID="bookLevel" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button CssClass="btn btn-light" ID="edit" runat="server" Text="edit book" OnClick="edit_Click" />
                <asp:Label ID="res" runat="server" Visible="false"></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>
