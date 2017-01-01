<%@ Page Language="C#" Async="true" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="YouTube.aspx.cs" Inherits="Dotnet4Techies.YouTube" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:ScriptManager ID="scm" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="upl" runat="server">
            <ContentTemplate>
                <span>Enter YouTube URL:</span>
                <br />
                <asp:TextBox ID="txtYouTubeURL" runat="server" Text="" Width="450" />
                <br />
                <asp:Button ID="btnDownload" Text="Download" runat="server" OnClick="btnDownload_Click" />
                <br />
                <br />
                <asp:Label ID="lblMessage" Text="" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="dk" runat="server" AssociatedUpdatePanelID="upl">
            <ProgressTemplate>
                Downloading..!
            </ProgressTemplate>
        </asp:UpdateProgress>
    </div>
</asp:Content>
