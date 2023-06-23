var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinuous').off('click').on('click', function (e) {
            e.preventDefault();
            window.location.href = "/";
        });

        $('#btnCheckOut').off('click').on('click', function (e) {
            e.preventDefault();
            window.location.href = "/payment";
        });

        $('#btnUpdateCart').off('click').on('click', function (e) {
            e.preventDefault();
            var listTouri = $('.txtQuanlity');
            var cartList = [];
            $.each(listTouri, function (i, item) {
                cartList.push({
                    Quanlity: $(item).val(),
                    Touri: {
                        ID: $(item).data('id')
                    }
                });
            });

            $.ajax({
                url: '/Cart/Update',
                data: { cartModel: JSON.stringify(cartList) },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = '/cart';
                    }
                }
            })
        });

        $('#btnDeleteCart').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: '/Cart/DeleteAll',                
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = '/cart';
                    }
                }
            })
        });

        $('.removeItemInCart').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                data: { id: $(this).data('id') },
                url: '/Cart/Delete',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = '/cart';
                    }
                }
            })
        });
    }
}

cart.init();