<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NumerologyCalculator._Default" Async="true"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
   
        <br />
        <br />
       
         <div class="form-inline">
        <asp:Label ID="LabelYear" runat="server" Text="Choose year"></asp:Label>
        <asp:DropDownList ID="DropDownListYear" runat="server" CssClass="form-control dropdown" Width="110px"></asp:DropDownList>

        <asp:Label ID="LabelMonth" runat="server" Text="Choose Month"></asp:Label>
        <asp:DropDownList ID="DropDownListMonth" runat="server" CssClass="form-control dropdown" Width="110px"></asp:DropDownList>

        <asp:Label ID="LabelDay" runat="server" Text="Choose Day"></asp:Label>
        <asp:DropDownList ID="DropDownListDay" runat="server" CssClass="form-control dropdown" Width="110px"></asp:DropDownList>
         </div>      
            <br />
       
           <asp:Label ID="LabelSelectedDate" runat="server" Text="Selected date:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Width="110px"></asp:TextBox>
          
            <br />
        <div class="form-inline">
            <asp:Button ID="Button1" runat="server" Text="Choose date" OnClick="Button1_Click" CssClass="btn btn-info" />
            
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Select Date" CssClass="btn btn-info"/>
            
            </div>
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server"  WeekendDayStyle-HorizontalAlign="Center" WeekendDayStyle-VerticalAlign="Middle" TitleStyle-VerticalAlign="Middle" DayStyle-VerticalAlign="Middle" DayStyle-HorizontalAlign="Center" SelectorStyle-HorizontalAlign="Center" SelectorStyle-VerticalAlign="Middle" BackColor="White" BorderColor="White" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender" OnPreRender="Button1_Click">

            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#31b0d5" Height="15pt" HorizontalAlign="Center" VerticalAlign="Middle" />
            <DayStyle BackColor="#CCCCCC" HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="White"/>
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#31b0d5" ForeColor="White" />
            <SelectorStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <TitleStyle BackColor="#31b0d5" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" VerticalAlign="Middle" BorderColor="#31B0D5" HorizontalAlign="Center" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
            <WeekendDayStyle HorizontalAlign="Center" VerticalAlign="Middle" />

        </asp:Calendar>
      

        <br />   
        <br />
        <asp:Label ID="Label1" runat="server" Text="Selected Date"></asp:Label>
       
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <br />
    
        <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" CssClass="btn btn-info" OnClick="ButtonCalculate_Click"  />

        <br />
        <br />  
        <asp:Label ID="LabelCalculatedValue" runat="server" Text="Calculated Number"></asp:Label>
        <asp:TextBox ID="TextBoxCalculatedValue" runat="server" CssClass="form-control"></asp:TextBox>
         <br />
            <br />
      
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>


            
</div>
</asp:Content>
