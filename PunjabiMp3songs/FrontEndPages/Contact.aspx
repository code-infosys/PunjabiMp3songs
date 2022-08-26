<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PunjabiMp3songs.FrontEndPages.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 class="hcontrol">Contact Us</h1>

    <div class="pageWrapper contactPageWrapper"> 
    
    <!-- map starts -->
    <div class="contactMapWrapper">
      <h4 class="contactTitle mapTitle">We Are Here:</h4>
      <iframe src="https://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=ro&amp;geocode=&amp;q=Envato+Pty+Ltd,+Elizabeth+Street,+Victoria,+Australia&amp;aq=0&amp;oq=envato&amp;sll=-37.818018,144.965147&amp;sspn=0.003725,0.008256&amp;ie=UTF8&amp;hq=Envato+Pty+Ltd,+Elizabeth+Street,+Victoria,+Australia&amp;ll=-37.817941,144.964977&amp;spn=0.017629,0.032015&amp;t=m&amp;output=embed" class="contactMap"></iframe>
    </div>
    <!-- map ends --> 
     
    <!-- contact form wrapper starts -->
    <div class="contactFormWrapper">
      <h4 class="contactTitle">Send Us An Email:</h4>
      <!-- form success message wrapper starts -->
      <div class="formSuccessMessageWrapper" runat="server" id="formSuccessMessageWrapper">
        <h4>Your message was received!</h4>
        <p>Your message was successfully submitted to us, and we will contact you as soon as possible.</p>
      </div>
      <!-- form success message wrapper ends --> 
      <!-- contact form starts -->
      <div class="contactForm" id="contactForm">
        <fieldset>
          <div class="formFieldWrapper">
            <label for="contactNameField">Name:</label>
            <asp:TextBox ID="txtName" CssClass="contactField requiredField" placeholder="Name" runat="server"></asp:TextBox>
          
          </div>
          <div class="formFieldWrapper">
            <label for="contactEmailField">Email:</label>
               <asp:TextBox ID="txtEmail" CssClass="contactField requiredField requiredEmailField" placeholder="Email ID" runat="server"></asp:TextBox>
            </div>
          <div class="formTextareaWrapper">
            <label for="contactMessageTextarea">Message:</label>
          <asp:TextBox ID="txtMsg" CssClass="contactTextarea requiredField" TextMode="MultiLine" placeholder="Message" runat="server"></asp:TextBox>
           </div>
          <div class="formSubmitButtonErrorsWrapper"> 
            <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" CssClass="buttonWrapper contactSubmitButton" Text="Send" /> 
          </div>
          
        </fieldset>
      </div>
      <!-- contact form ends --> 
    </div>
    <!-- contact form wrapper ends --> 
    
  </div>
</asp:Content>
