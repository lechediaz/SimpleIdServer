﻿@model SimpleIdServer.UI.Authenticate.LoginPassword.ViewModels.AuthenticateViewModel
@using $rootnamespace$.Resources

@{
    ViewBag.Title = Global.authenticate_pwd;
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<div>
    <div class="card" id="loginpwd-card">
        <div class="card-header">@Global.authenticate_pwd</div>
        @using (Html.BeginForm("Index", "Authenticate", new { area = "pwd", returnUrl = Model.ReturnUrl }, FormMethod.Post))
        {
            @Html.AntiForgeryToken()
            <div class="card-body">
                @if (!string.IsNullOrWhiteSpace(Model.LogoUri))
                {
                    <img class="card-img-top rounded mx-auto d-block" src="@Model.LogoUri" style="max-width: 300px" />
                }
                <h5 class="card-title">@Model.ClientName</h5>
                @if (!ViewData.ModelState.IsValid)
                {
                    <ul class="list-group">
                        @foreach (var modelState in ViewData.ModelState.Values)
                        {
                            foreach (var error in modelState.Errors)
                            {
                                <li class="list-group-item list-group-item-danger">@Global.ResourceManager.GetString(error.ErrorMessage)</li>
                            }
                        }
                    </ul>
                }
                <input type="hidden" value="@Model.ReturnUrl" name="ReturnUrl" />
                <div class="form-group">
                    <label>@Global.login</label>
                    <input type="text" value="@Model.Login" name="Login" class="form-control" />
                </div>
                <div class="form-group">
                    <label>@Global.password</label>
                    <input type="password" value="@Model.Password" name="Password" class="form-control" />
                </div>
                <div>
                    <input type="checkbox" value="@Model.RememberLogin" name="RememberLogin" />
                    <label>@Global.remember_login</label>
                </div>
            </div>
            <div class="card-footer">
                <button type="submit" class="btn btn-primary card-link">@Global.submit</button>
                <div style="float: right">
                    @if (!string.IsNullOrWhiteSpace(Model.TosUri))
                    {
                        <a href="@Model.TosUri" target="_blank">@Global.tos</a>
                    }

                    @if (!string.IsNullOrWhiteSpace(Model.PolicyUri))
                    {
                        <a href="@Model.PolicyUri" target="_blank">@Global.policy</a>
                    }
                </div>
            </div>
        }
    </div>
</div>

@section Scripts {
    <script type="text/javascript">
        $(document).ready(function () {
            $("#loginpwd-card form input[name='RememberLogin']").change(function (e) {
                $(this).val($(this).is(':checked'));
            });
        });
    </script>
}