let open = false;
let isCheckData = false;
let amountUser = 0;
let nameUser = '';
let phoneUser = '';
let amountOpen = 0;

$(document).ready(() => {
    $('.phone-user').removeClass('unShow');
    renderLiXi();
});

function formatPhoneNum(str) {
    var result = str.replace('(', '').replace(')', '').replace(' ', '').replace('-', '');
    if (result.length < 3) {
        result = '(' + result;
    } else if (result.length < 4) {
        result = '(' + result.substr(0, 3) + '';
    } else if (result.length <= 6 && result.length > 3) {
        result = '(' + result.substr(0, 3) + ') ' + result.substr(3, result.length - 3);
    } else if (result.length > 6) {
        result = '(' + result.substr(0, 3) + ') ' + result.substr(3, 3) + '-' + result.substr(6, result.length - 6);
    }
    return result;
}

function renderLiXi() {
    let wSC = $(window).width();
    for (let i = 0; i <= 4; i++) {
        if (wSC < 500 && i > 3) {
            return false;
        }
        setTimeout(() => {
            let temp = `<div class="lixi-each" data-index="${i}">
                                    <div class="before-lixi controll-click">
                                        <img src="/images/LiXiTet/lixi${i}.png" class="img-lixi" />
                                    </div>
                                    <div class="after-lixi unShow" data-amount="">
                                        <div class="lixi-sucss-title">Chúc Mừng, Bạn Nhận Được</div>
                                        <div class="amount-lixi"></div>
                                    </div>
                                </div>`;
            $('body').find('.grid-lixi').append(temp);
        }, 500);
    }
}

function getUser(phone) {
    $.ajax({
        async: false,
        type: 'GET',
        url: '/Home/getUserByPhone',
        data: { phone: phone },
        success: function (data) {
            if (data.code == 200) {
                let res = data.data;
                nameUser = res.User[0].name;
                phoneUser = res.User[0].phone;
                amountUser = res.User[0].amount;
                if (res.CanPlay == true) {
                    isCheckData = true;
                    $('.li-xi-title').text('Chúc ' + nameUser + ' năm mới thật nhiều yêu thương!').animate({ 'opacity': '1' }, 500);

                    jQuery.each(res.RenderAmount, function (index, item) {
                        item = item.toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1.");
                        $('body').find(`.lixi-each[data-index='${index}']`).find('.after-lixi').attr('data-amount', item);
                        $('body').find(`.lixi-each[data-index='${index}']`).find('.amount-lixi').text(item + ' VNĐ');
                    });

                    $('.phone-user').addClass('unShow');
                }
                else {
                    let amount = amountUser.toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1.");
                    $('.li-xi-title').text('Chúc ' + nameUser + ' năm mới thật nhiều yêu thương!').animate({ 'opacity': '1' }, 500);
                    $('.phone-user').addClass('unShow');
                    $('.message-title').text(nameUser + ' đã nhận được ' + amount + ' VNĐ, chờ năm sau để chơi tiếp nhé :v');
                    $('.message-content').text('Phần thưởng sẽ được chuyển vào tài khoản Momo của ' + nameUser + ' trước 2h mùng 1 tết 2021!');
                    $('.message').removeClass('unShow');
                }
            }
            else {
                $('.message-content').text('Nhắn cho Hiếu Nhỏ nhé :((');
                $('.message-title').text('Số Điện Thoại Không Có Trong Hệ Thống');
                $('.message').removeClass('unShow');
            }
        }
    });
}


function setAmountOpen(p, a) {
    $.ajax({
        type: 'POST',
        url: '/Home/setAmountOpen',
        data: { phone: p, amount: a },
        success: function (data) {

        }
    });
}

$('body').on('mouseover', '.before-lixi', function (e) {
    $(this).addClass('mouseover');
});

$('body').on('mouseout', '.before-lixi', function (e) {
    $(this).removeClass('mouseover');
});

$('body').on('click', '.controll-click', function (e) {
    if (open == true) {
        return;
    }
    open = true;
    if (isCheckData == false) {
        return;
    }
    else {
        if ($(this).hasClass('before-lixi')) {
            $(this).addClass('rotateY');
            setTimeout(() => {
                $(this).addClass('unShow');
                $(this).parent().find('.after-lixi').removeClass('unShow');
                $(this).parent().find('.after-lixi').addClass('returnY');
                setTimeout(() => {
                    amountOpen = $(this).parent().find('.after-lixi').attr('data-amount').replace('.', '').replace(',', '');
                    $(this).parent().find('.after-lixi').css('transform', 'rotateY(0deg)');
                    setAmountOpen(phoneUser, amountOpen);
                }, 1500);
            }, 750);
        }
    }
});


$('.btn-phone-xoa').on('click', function (e) {
    $('.input-phone').val('');
});

$('.input-phone').on('keypress', function (evt) {
    let value = $(this).val();
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    else {
        $(this).val(formatPhoneNum(value));
    }
});

$('.btn-phone-oke').on('click', function (e) {
    let phone = $('.input-phone').val().replace('(', '').replace(')', '').replace(' ', '').replace('-', '');
    if (phone.length > 0) {
        getUser(phone);
    }
});

$('.btn-mess-ok').on('click', function (e) {
    window.location.href = 'https://www.facebook.com/HieuLe.9420/';
});