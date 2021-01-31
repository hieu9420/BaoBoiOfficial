$('.btn-login').on('click', function (e) {
    let value = $('.input-code').val();
    if (value == '' || value == undefined) {
        return false;
    }
    else {
        $.ajax({
            url: '/admin/loginAdmin',
            type: 'POST',
            data: { code: value },
            success: function (data) {
                if (data.code == 200) {
                    $('.admin-area').removeClass('unShow');
                    $('.login-page-area').addClass('unShow');
                }
            }

        });
    }
});