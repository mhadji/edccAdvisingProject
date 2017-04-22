<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eq.aspx.cs" Inherits="edcc.Reports.eq" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 157px;
        }
        .auto-style3 {
            width: 440px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <table style="width: 48%;">
            <tr>
                <td class="auto-style3">
        <asp:ListBox ID="ListUniversities" runat="server" DataSourceID="DS_un_list" DataTextField="University" DataValueField="University" Height="242px" SelectionMode="Multiple" Width="467px"></asp:ListBox>
                </td>
                <td class="auto-style2">
        <asp:ListBox ID="ListPrograms" runat="server" DataSourceID="DS_pr_list" DataTextField="Major" DataValueField="Major" Height="242px" Width="467px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
        <asp:Label ID="lblSelected" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">
        <asp:Label ID="lblSelectedPr" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
        <asp:SqlDataSource ID="DS_un_list" runat="server" ConnectionString="<%$ ConnectionStrings:edcc_advisingConnectionString %>" SelectCommand="SELECT DISTINCT [University] FROM [Transfers] ORDER BY [University]"></asp:SqlDataSource>
                </td>
                <td class="auto-style2">
        <asp:SqlDataSource ID="DS_pr_list" runat="server" ConnectionString="<%$ ConnectionStrings:edcc_advisingConnectionString %>" SelectCommand="SELECT DISTINCT Major FROM Transfers ORDER BY Major"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search!!!" />
        <br />
        <br />
    
    </div>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="509px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1395px">
            <LocalReport ReportPath="Reports\Report1.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ds_report" Name="DataSet1" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:SqlDataSource ID="ds_report" runat="server" ConnectionString="<%$ ConnectionStrings:edcc_advisingConnectionString %>" SelectCommand="Report" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="lblSelected" DefaultValue="NA" Name="un_list" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="lblSelectedPr" DefaultValue="NA" Name="pr_list" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
