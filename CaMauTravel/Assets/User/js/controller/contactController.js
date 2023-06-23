var contact = {
    init: function () {
        contact.registerEvents();
    },
    registerEvents: function () {
        $('#btnSend').off('click').on('click', function () {
            var name = $('#txtname').val();
            var mobile = $('#txtmobile').val();
            var address = $('#txtaddress').val();
            var email = $('#txtemail').val();
            var content = $('#txtcontent').val();


            $.ajax({
                url: '/Contact/Send',
                type: 'POST',
                dataType: 'json',
                data: {
                    name: name,
                    mobile: mobile,
                    address: address,
                    email: email,
                    content: content
                },
                success: function (res) {
                    if (res.status == true) {
                        window.alert('Send Feedback Success!');
                        contact.resetForm();
                    }
                }
            });
        });
    },
    resetForm: function () {
        $('#txtname').val('');
        $('#txtmobile').val('');
        $('#txtaddress').val('');
        $('#txtemail').val('');
        $('#txtcontent').val('');
    }
}

contact.init();