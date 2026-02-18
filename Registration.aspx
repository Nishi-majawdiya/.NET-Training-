<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="Registration.aspx.cs" 
    Inherits="Registration_Form.Registration_Form" %>


<!DOCTYPE html>
<html>
<head runat="server">
    <title>Registration Form</title>

    <!-- Bootstrap CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        body {
            background: linear-gradient(to right, #82a7fff2, #8fcfeb);
        }
        .card {
            border-radius: 35px;
        }
    </style>
</head>

<body>
<form id="form1" runat="server">
    <asp:ValidationSummary 
    ID="ValidationSummary1"
    runat="server"
    ShowSummary="false"
    ShowMessageBox="false" />

    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-8">
                <div class="card shadow p-4">

                    <h3 class="text-center mb-4 text-primary">Registration Form</h3>

                    <!-- Validation summary-->
                    <asp:ValidationSummary 
    ID="ValidationSummary2"
    runat="server"
    CssClass="alert alert-danger"
    HeaderText="Please fix the following errors:"
    DisplayMode="BulletList"
    ShowSummary="true"
    ShowMessageBox="false" />


                    <!-- First Name -->
                    <div class="mb-3">
    <label class="form-label">First Name</label>

    <asp:TextBox ID="txtFirstName"
        runat="server"
        CssClass="form-control" />

    <asp:RequiredFieldValidator ID="rfvFirstName"
        runat="server"
        ControlToValidate="txtFirstName"
        ErrorMessage="First Name required"
        CssClass="text-danger"
        Display="Dynamic" />

    <asp:RegularExpressionValidator ID="revFirstName"
        runat="server"
        ControlToValidate="txtFirstName"
        ValidationExpression="^[A-Z][a-z]*$"
        ErrorMessage="First letter must be capital and only alphabets allowed"
        CssClass="text-danger"
        Display="Dynamic" />
</div>


                    <!-- Last Name -->
                   <div class="mb-3">
    <label class="form-label">Last Name</label>

    <asp:TextBox ID="txtLastName"
        runat="server"
        CssClass="form-control" />

    <asp:RequiredFieldValidator ID="rfvLastName"
        runat="server"
        ControlToValidate="txtLastName"
        ErrorMessage="Last Name required"
        CssClass="text-danger"
        Display="Dynamic" />

    <asp:RegularExpressionValidator ID="revLastName"
        runat="server"
        ControlToValidate="txtLastName"
        ValidationExpression="^[A-Z][a-zA-Z]*$"
        ErrorMessage="First letter must be capital and only alphabets allowed"
        CssClass="text-danger"
        Display="Dynamic" />
</div>

                   <!-- Contact -->
<div class="mb-3">
    <label class="form-label">Contact No</label>

    <asp:TextBox ID="txtContact"
        runat="server"
        CssClass="form-control"
        MaxLength="10"
        placeholder="Enter 10 digit number" />

    <asp:RequiredFieldValidator ID="rfvContact"
        runat="server"
        ControlToValidate="txtContact"
        ErrorMessage="Contact number is required"
        CssClass="text-danger"
        Display="Dynamic" />

    <asp:RegularExpressionValidator ID="revContact"
        runat="server"
        ControlToValidate="txtContact"
        ValidationExpression="^[0-9]{10}$"
        ErrorMessage="Enter valid 10 digit number"
        CssClass="text-danger"
        Display="Dynamic" />
</div>


                    <!-- Email -->
                    <div class="mb-3">
                        <label class="form-label">Email</label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                            ControlToValidate="txtEmail"
                            ErrorMessage="Email required"
                            CssClass="text-danger" />
                        <asp:RegularExpressionValidator ID="revEmail" runat="server"
                            ControlToValidate="txtEmail"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            ErrorMessage="Invalid email"
                            CssClass="text-danger" />
                    </div>

                   <!-- Date of Birth -->
                  <div class="mb-3">
                 <label class="form-label">Date of Birth</label>

                 <asp:TextBox ID="txtDOB"
        runat="server"
        TextMode="Date"
        CssClass="form-control"
        onkeydown="return false;"
        onpaste="return false;" />

    <asp:RequiredFieldValidator ID="rfvDOB"
        runat="server"
        ControlToValidate="txtDOB"
        ErrorMessage="Date of Birth is required"
        CssClass="text-danger"
        Display="Dynamic" />
</div>

                <!-- Gender -->
                    <div class="mb-3">
                        <label class="form-label">Gender</label><br />
                        <asp:RadioButton ID="rbMale" runat="server" GroupName="Gender" Text="Male" />
                        <asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="Female" />
                    </div>

                   <!-- Password -->
                <div class="mb-3">
              <label class="form-label">Password</label>
              <asp:TextBox ID="txtPassword" runat="server"
               TextMode="Password"
               CssClass="form-control" />

    <asp:RequiredFieldValidator ID="rfvPassword" runat="server"
        ControlToValidate="txtPassword"
        ErrorMessage="Password is required"
        CssClass="text-danger" />

    <asp:RegularExpressionValidator ID="revPassword" runat="server"
        ControlToValidate="txtPassword"
        ValidationExpression="^(?=.*[A-Z])(?=.*[\W_]).{8,}$"
        ErrorMessage="Password must be 8+ chars, include 1 uppercase & 1 special character"
        CssClass="text-danger" 
        Display="Dynamic"/>
</div>


                    <!-- Confirm Password -->
                    <div class="mb-3">
                        <label class="form-label">Confirm Password</label>
                        <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password" CssClass="form-control" />
                        <asp:CompareValidator ID="cvPassword" runat="server"
                            ControlToValidate="txtConfirm"
                            ControlToCompare="txtPassword"
                            ErrorMessage="Passwords do not match"
                            CssClass="text-danger" />
                    </div>

                    <!-- Address -->
<!-- Address -->
<div class="mb-3">
    <label class="form-label">Address</label>

    <asp:TextBox ID="txtAddress"
        runat="server"
        TextMode="MultiLine"
        Rows="3"
        CssClass="form-control" />

    <asp:RequiredFieldValidator ID="rfvAddress"
        runat="server"
        ControlToValidate="txtAddress"
        ErrorMessage="Address is required"
        CssClass="text-danger"
        Display="Dynamic" />
</div>

                   <!-- Vaccinated -->
<div class="mb-3">
    <label class="form-label">Vaccinated</label><br />

    <input type="radio" name="vaccinated" value="Yes"
           onclick="toggleFileUpload(true)"> Yes

    <input type="radio" name="vaccinated" value="No"
           onclick="toggleFileUpload(false)"> No
</div>

<!-- File Upload -->
<div class="mb-3" id="uploadDiv" style="display:none;">
    <asp:FileUpload ID="fileCertificate"
        runat="server"
        CssClass="form-control" />
</div>


                    <!-- Submit -->
                    <div class="text-center">
                        <asp:Button ID="btnSubmit"
                            runat="server"
                            Text="Register"
                            CssClass="btn btn-primary"
                            OnClick="btnSubmit_Click" />
                    </div>

                    <asp:Label ID="lblMessage" runat="server" CssClass="text-success mt-3"></asp:Label>
                    <asp:Label ID="lblResult" runat="server" CssClass="text-success mt-3"></asp:Label>
                    <asp:Label ID="lblResult1" runat="server" CssClass="text-success mt-3"></asp:Label>
                    <asp:Label ID="lblResult2" runat="server" CssClass="text-success mt-3"></asp:Label>
                    <asp:Label ID="lblResult3" runat="server" CssClass="text-success mt-3"></asp:Label>
                    <asp:Label ID="lblResult5" runat="server" CssClass="text-success mt-3"></asp:Label>
                    <asp:Label ID="lblResult6" runat="server" CssClass="text-success mt-3"></asp:Label>
                    <asp:Label ID="lblSolution" runat="server" CssClass="text-success mt-3"></asp:Label>
                    <asp:Label ID="lblLogical" runat="server" CssClass="text-success mt-3"></asp:Label>
                    <asp:Label ID="lblForLoop" runat="server" CssClass="text-success mt-3"></asp:Label>
                 <asp:Label ID="lblContinue" runat="server" CssClass="text-success mt-3"></asp:Label>
                 <asp:Label ID="lblBreak" runat="server" CssClass="text-success mt-3"></asp:Label>
                     <asp:Label ID="lblSwitch" runat="server" CssClass="text-success mt-3"></asp:Label>

                    


                </div>
            </div>
        </div>
    </div>

    <!-- Server Side Code -->
    <script>
        function toggleFileUpload(show) {
            document.getElementById("uploadDiv").style.display =
                show ? "block" : "none";
        }
    </script>


</form>
</body>
</html>