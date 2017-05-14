<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="edccAdvisingProject.eq.WebForm1" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6" style="height: 300px; overflow-y: scroll">
            <h4>Universities</h4>
            <p>
                <asp:CheckBox ID="CBuntoggol" runat="server" AutoPostBack="True" OnCheckedChanged="CBuntoggol_CheckedChanged" Text="Select All" Font-Size="X-Small" />
            </p>
            <asp:CheckBoxList ID="CBLuniversities" runat="server" DataSourceID="DSun" DataTextField="University" DataValueField="University" Font-Size="X-Small"></asp:CheckBoxList>
            <asp:SqlDataSource ID="DSun" runat="server" ConnectionString="<%$ ConnectionStrings:edcc_advisingConnectionString %>" SelectCommand="SELECT DISTINCT University FROM University ORDER BY University"></asp:SqlDataSource>
        </div>
        <div class="col-md-6" style="overflow-y: scroll; height: 300px">
            <h4>Programs</h4>
            <p>
                <asp:CheckBox ID="CBprtoggol" runat="server" AutoPostBack="True" Text="Select ALL" Font-Size="X-Small" OnCheckedChanged="CBprtoggol_CheckedChanged" />
            </p>
            <asp:CheckBoxList ID="CBLprograms" runat="server" DataSourceID="DSpr" DataTextField="Major" DataValueField="Major" Font-Size="X-Small"></asp:CheckBoxList>
          
            <asp:SqlDataSource ID="DSpr" runat="server" ConnectionString="<%$ ConnectionStrings:edcc_advisingConnectionString %>" SelectCommand="SELECT Major FROM major ORDER BY Major"></asp:SqlDataSource>
        </div>
        <div class="row">
            <div class="col-md-6">
                <br />
                Selected Universities:<br />
                <asp:Label ID="LBLun" runat="server" Text=""></asp:Label>
            </div>
            <div class="col-md-6">
                <br />
                Selected Programs:<br />
                <asp:Label ID="LBLpr" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div class="row">
                <asp:Button ID="BTNsearch" runat="server" Text="Search!!!" OnClick="BTNsearch_Click" />

                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1304px" Height="1203px">
                    <LocalReport ReportPath="eq\Reports\Report1.rdlc">
                        <DataSources>
                            <rsweb:ReportDataSource DataSourceId="DSreport" Name="DataSet1" />
                        </DataSources>
                    </LocalReport>
                </rsweb:ReportViewer>
            </div>
        </div>
        <div class="row">
            <br />
            <asp:SqlDataSource ID="DSreport" runat="server" ConnectionString="<%$ ConnectionStrings:edcc_advisingConnectionString %>" SelectCommand="Report" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="LBLun" Name="un_list" PropertyName="Text" Type="String" DefaultValue="NA" />
                    <asp:ControlParameter ControlID="LBLpr" Name="pr_list" PropertyName="Text" Type="String" DefaultValue="NA" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>

    </div>

</asp:Content>
