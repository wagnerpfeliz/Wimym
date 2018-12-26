﻿$('#editModal').on('shown.bs.modal', function () {
    $('#myInput').focus()
})

var items;
var j = 0;
var id;
var userName;
var email;
var phoneNumber;

var accessFailedCount;
var concurrencyStamp;
var emailConfirmed;
var lockoutEnabled;
var lockoutEnd;
var normalizedUserName;
var normalizedEmail;
var passwordHash;
var phoneNumberConfirmed;
var securityStamp;
var twoFactorEnabled;

function getUser(id, action) {
    $.ajax({
        type: "POST",
        url: action,
        data: { id },
        success: function (response) {
            showUser(response);
        }
    })
}

function showUser(response) {
    items = response;
    j = 0;
    for (var i = 0; i < 3; i++) {
        var x = document.getElementById('Select');
        x.remove(i);
    }

    $.each(items, function (index, val) {
        $('input[name=Id]').val(val.id);
        $('input[name=UserName]').val(val.userName);
        $('input[name=Email]').val(val.email);
        $('input[name=PhoneNumber]').val(val.phoneNumber);
        document.getElementById('Select').options[0] = newOption(val.role, val.roleId);
    });
}

function getRols(action) {
    $.ajax({
        type: "POST",
        url: action,
        data: {},
        success: function (response)
        {
            if (j == 0)
            {
                for (vari = 0; i < response.length; i++)
                {
                    document.getElementById('Select').options[i] = newOption(response[i].text, response[i].value);
                }
                j = 1;
            }
        }
    });
}

function editUser(action) {
    id = $('input[name=Id]')[0].value;
    email = $('input[name=Email]')[0].value;
    phoneNumber = $('input[name=PhoneNumber]')[0].value;

    $.each(items, function (index, val) {
        accessFailedCount = val.accessFailedCount;
        concurrencyStamp = val.concurrencyStamp;
        emailConfirmed = val.emailConfirmed;
        lockoutEnabled = val.lockoutEnabled;
        lockoutEnd = val.lockoutEnd;
        userName = val.userName;
        normalizedUserName = val.normalizedUserName;
        normalizedEmail = val.normalizedEmail;
        passwordHash = val.passwordHash;
        phoneNumberConfirmed = val.phoneNumberConfirmed;
        securityStamp = val.securityStamp;
        twoFactorEnabled = val.twoFactorEnabled;
    });
    $.ajax({
        type: "POST",
        url: action,
        data: {
            id, userName, email, phoneNumber, accessFailedCount,
            concurrencyStamp,
            emailConfirmed,
            lockoutEnabled,
            lockoutEnd,
            normalizedUserName,
            normalizedEmail,
            passwordHash,
            phoneNumberConfirmed,
            securityStamp,
            twoFactorEnabled
        },
        success: function (response) {
            if (response = "Saved") {
                window.location.href = "Users";
            }
            else {
                alert("Something was wrong!!!");
            }
        }
    })
}
