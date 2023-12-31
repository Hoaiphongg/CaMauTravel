﻿var touris = {
    init: function () {
        touris.registerEvents();
    },
    registerEvents: function () {
        $('.btn-active').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this); 
            var id = btn.data('id');
            $.ajax({
                url: "/Admin/Touris/ChangeStatus",
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    if (response.status == true) {
                        btn.text('Enable');
                    }
                    else {
                        btn.text('Disable');
                    }
                }
            });
        });
    }
}
touris.init();