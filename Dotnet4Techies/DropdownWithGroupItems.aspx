<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="DropdownWithGroupItems.aspx.cs"
    Inherits="Dotnet4Techies.DropdownWithGroupItems" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="ddlNotebookModel" runat="server" OnDataBound="dllNotebook_DataBound">
    </asp:DropDownList>
</asp:Content>
